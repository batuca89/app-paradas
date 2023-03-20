using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paradas.models
{
    internal class ValidacionesTurnos : AbstractValidator<String>
    {
        public ValidacionesTurnos(String horaInicioParada, String minutosInicioParada, String horaFinParada, String minutosFinParada, String personas, String sector, String turno, String bins)
        {


            RuleFor(x => horaInicioParada).NotEmpty().NotNull().WithMessage("Error:La hora de inicio de la parada no puede estar vacio");
            RuleFor(x => minutosInicioParada).NotEmpty().NotNull().WithMessage("Error:Los minutos de inicio de la parada no puede estar vacio");
            RuleFor(x => horaFinParada).NotEmpty().NotNull().WithMessage("Error:La hora de fin de la parada no puede estar vacio");
            RuleFor(x => minutosFinParada).NotEmpty().NotNull().WithMessage("Error:Los minutos de fin de la parada no puede estar vacio");
            RuleFor(x => personas).NotEmpty().NotNull().WithMessage("Error el campo cantidad de personas no puede estar vacio");
            RuleFor(x => sector).NotEmpty().NotNull().WithMessage("Error: Falta seleccionar el campo sector");
            RuleFor(x => turno).NotEmpty().NotNull().WithMessage("Error: Falta seleccionar el campo turno");
            RuleFor(x => bins).NotEmpty().NotNull().WithMessage("Error: el campo cantidad de bines no puede estar vacio");


        }
    }
}
