/*
 * @fileoverview    {Sancion}
 *
 * @version         2.0
 *
 * @author          Dyson Arley Parra Tilano <dysontilano@gmail.com>
 *
 * @copyright       Dyson Parra
 * @see             github.com/DysonParra
 *
 * History
 * @version 1.0     Implementation done.
 * @version 2.0     Documentation added.
 */
using System;
using System.ComponentModel.DataAnnotations;

/**
 * TODO: Description of {@code Sancion}.
 *
 * @author Dyson Parra
 */
namespace Project.Models {

    public class Sancion {

        [Key]
        public Int32? IntNumero { get; set; }
        public String? StrItem { get; set; }
        public Boolean? BitSancionConductor { get; set; }
        public Boolean? BitSancionVehiculo { get; set; }
        public String? StrTiempo { get; set; }

    }

}