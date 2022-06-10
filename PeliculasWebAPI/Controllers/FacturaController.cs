using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PeliculasWebAPI.Entidades;
using PeliculasWebAPI.Entidades.Funciones;

namespace PeliculasWebAPI.Controllers {
    [ApiController]
    [Route("api/facturas")]
    public class FacturaController : ControllerBase {
        private readonly ApplicationDBContext context;

        public FacturaController(ApplicationDBContext context) {
            this.context = context;
        }

        [HttpGet("Func_Esca")]
        public async Task<IActionResult> GetFuncEsc() {
            var facturas = await context.Facturas
                                        .Select(f => new {
                                            Id       = f.Id,
                                            Total    = context.FacturaDetalleSuma(f.Id),
                                            Promedio = Escalares.FacturaDetallePromedio(f.Id)
                                        })
                                        .OrderByDescending(f => context.FacturaDetalleSuma(f.Id))
                                        .ToListAsync();

            return Ok(facturas);
        }

        [HttpPost]
        public async Task<ActionResult> Post() {
            using var transaccion = await context.Database.BeginTransactionAsync();
            
            try {
                var factura = new Factura() {
                    FechaCreacion = DateTime.Now
                };

                context.Add(factura);
                await context.SaveChangesAsync();

                /* Simula Error */
                //throw new ApplicationException("Esto es una prueba");

                var facturaDetalle = new List<FacturaDetalle>() {
                                        new FacturaDetalle() {
                                            Producto  = "Producto A",
                                            Precio    = 123,
                                            FacturaId = factura.Id
                                        },
                                        new FacturaDetalle() {
                                            Producto  = "Producto B",
                                            Precio    = 456,
                                            FacturaId = factura.Id
                                        }
                                      };

                context.AddRange(facturaDetalle);
                await context.SaveChangesAsync();
                await transaccion.CommitAsync();

                return Ok("Todo bien");
            } catch (Exception e) {
                return BadRequest("Hubo un error, se revirtió la operación");
            }  
        }
    }
}
