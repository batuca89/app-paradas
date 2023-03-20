using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paradas.models
{
    internal class Validaciones : AbstractValidator<String>
    {
        public Validaciones(String horaInicioParada, String minutosInicioParada, String horaFinParada, String minutosFinParada, String nombre, String sector, String turno, String problema) {

         
                RuleFor(x => horaInicioParada).NotEmpty().NotNull().WithMessage("Error:La hora de inicio de la parada no puede estar vacio");
                RuleFor(x => minutosInicioParada).NotEmpty().NotNull().WithMessage("Error:Los minutos de inicio de la parada no puede estar vacio");
                RuleFor(x => horaFinParada).NotEmpty().NotNull().WithMessage("Error:La hora de fin de la parada no puede estar vacio");
                RuleFor(x => minutosFinParada).NotEmpty().NotNull().WithMessage("Error:Los minutos de fin de la parada no puede estar vacio");
                RuleFor(x => nombre).NotEmpty().NotNull().WithMessage("Error: Falta seleccionar el campo nombre");
                RuleFor(x => sector).NotEmpty().NotNull().WithMessage("Error: Falta seleccionar el campo sector");
                RuleFor(x => turno).NotEmpty().NotNull().WithMessage("Error: Falta seleccionar el campo turno");
                RuleFor(x => problema).NotEmpty().NotNull().WithMessage("Error: Falta seleccionar el campo problema");
          

            
        }
    }
}
