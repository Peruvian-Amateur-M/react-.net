using FinalHPII_PANOCCA_ROMERO_ANDRES.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FinalHPII_PANOCCA_ROMERO_ANDRES.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultasEFAPIController : ControllerBase
    {
        //variable del contxto
        BDNOTAS2023okContext db = new BDNOTAS2023okContext();

        // pregunta 1.1
        [HttpGet("GetPagoAlumnos/{cod_alum}/{semestre}")]
        public ActionResult<List<PA_PAGOS_ALUMNO>> GetPagosAlumnos(string cod_alum,string semestre)
        {
            var listado = db.PA_PAGOS_ALUMNO
                            .FromSqlRaw<PA_PAGOS_ALUMNO>(
                            "exec PA_PAGOS_ALUMNO {0}, {1}",cod_alum,semestre).ToList();
            return Ok(listado);                
        }

        // preg. 1.3
        [HttpGet("GetEspecialidades")]
        public ActionResult<List<Especialidad>> GetEspecialidades()
        {
            var listado = db.Especialidads.ToList();
            //
            return Ok(listado);
        }

        // preg. 1.4
        [HttpGet("GetAlumnos")]
        public ActionResult<List<Alumno>> GetAlumnos()
        {
            var listado = db.Alumnos.ToList();
            //
            return Ok(listado);
        }

        // preg 1.5
        // POST
        [HttpPost("PostAlumno")]
        public string Post([FromBody] Alumno obj)
        {
            try
            {
                // grabar en memoria
                db.Alumnos.Add(obj);
                // grabar en la bd
                db.SaveChanges();
                return "Alumno registrado satisfactoriamente";
            }
            catch (System.Exception ex)
            {
                return ex.Message;
            }
        }



        

       

        // preg 1.2 - me falta =( 

        // PUT api/<ConsultasEFAPIController>/5
        [HttpPut("PutActualizarCuota/{cod_alum}")]
        public string Put(string cod_alum,[FromBody] Pago obj)
        {
            try
            {
                var listado = db.Pagos.Include(x => x.Codpago)
                                       .Include(y => y.Codalumno)
                                      .ToList();
                db.Update(obj);
                db.SaveChanges();
                return "Cuota Actualizada";
            }
            catch (System.Exception ex)
            {
                return "Error:" + ex.Message;
            }

        }


        
        




        // DELETE api/<ConsultasEFAPIController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
