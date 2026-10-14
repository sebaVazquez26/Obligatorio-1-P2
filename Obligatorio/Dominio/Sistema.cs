namespace Dominio
{
    public class Sistema
    {

        public Sistema()
        {
            PrecargarDatos();
        }

        private List<Caso> _casos = new List<Caso>();
        private List<Sospechoso> _sospechosos = new List<Sospechoso>();
        private List<Investigador> _investigadores = new List<Investigador>();

        public List<Caso> Casos { get { return _casos; }}
        public List<Sospechoso> Sospechosos { get { return _sospechosos; }}
        public List<Investigador> Investigadores { get { return _investigadores; }}

        public void AgregarSospechoso(Sospechoso s)
        {
            //Valido que no sea null
            if (s == null) throw new Exception("Datos inválidos");
            //Valido los datos
            //if () ;
            //Verifico que no exista ese mismo sospechoso
            if (_sospechosos.Contains(s)) throw new Exception("Ese sospechoso ya esta registrado");
            //Agrego al sospechoso
            _sospechosos.Add(s);
        }

        public void PrecargarDatos()
        { 
            // =========================
            // INVESTIGADORES
            // =========================

            Investigador detective1 = new Investigador("ana.garcia@fiscalia.uy", "Ana2026!", "Ana García", Rol.DETECTIVE);
            Investigador detective2 = new Investigador("martin.silva@fiscalia.uy", "Martin2026!", "Martín Silva", Rol.DETECTIVE);
            Investigador detective3 = new Investigador("lucia.rodriguez@fiscalia.uy", "Lucia2026!", "Lucía Rodríguez", Rol.DETECTIVE);
            Investigador detective4 = new Investigador("diego.martinez@fiscalia.uy", "Diego2026!", "Diego Martínez", Rol.DETECTIVE);
            Investigador detective5 = new Investigador("sofia.pereira@fiscalia.uy", "Sofia2026!", "Sofía Pereira", Rol.DETECTIVE);

            Investigador fiscal1 = new Investigador("carlos.fernandez@fiscalia.uy", "Carlos2026!", "Carlos Fernández", Rol.FISCAL);
            Investigador fiscal2 = new Investigador("valentina.lopez@fiscalia.uy", "Valentina2026!", "Valentina López", Rol.FISCAL);
            Investigador fiscal3 = new Investigador("federico.sosa@fiscalia.uy", "Federico2026!", "Federico Sosa", Rol.FISCAL);
            Investigador fiscal4 = new Investigador("camila.torres@fiscalia.uy", "Camila2026!", "Camila Torres", Rol.FISCAL);
            Investigador fiscal5 = new Investigador("rodrigo.cabrera@fiscalia.uy", "Rodrigo2026!", "Rodrigo Cabrera", Rol.FISCAL);


            // =========================
            // SOSPECHOSOS
            // =========================

            Sospechoso sospechoso1 = new Sospechoso("Alejandro Núñez", 45827316, true, new DateTime(1987, 03, 14));
            Sospechoso sospechoso2 = new Sospechoso("Bruno Acosta", 51039248, false, new DateTime(1992, 07, 22));
            Sospechoso sospechoso3 = new Sospechoso("Carolina Méndez", 39214752, false, new DateTime(1985, 11, 09));
            Sospechoso sospechoso4 = new Sospechoso("Damián Olivera", 47351829, true, new DateTime(1990, 01, 17));
            Sospechoso sospechoso5 = new Sospechoso("Esteban Viera", 52846131, false, new DateTime(1996, 05, 30));
            Sospechoso sospechoso6 = new Sospechoso("Florencia Castro", 41968275, false, new DateTime(1988, 09, 12));
            Sospechoso sospechoso7 = new Sospechoso("Gonzalo Cabrera", 38472917, true, new DateTime(1982, 02, 25));
            Sospechoso sospechoso8 = new Sospechoso("Helena Suárez", 54216384, false, new DateTime(1998, 12, 03));
            Sospechoso sospechoso9 = new Sospechoso("Ignacio Perdomo", 46743153, true, new DateTime(1991, 06, 19));
            Sospechoso sospechoso10 = new Sospechoso("Julieta Ramos", 50164927, false, new DateTime(1994, 10, 28));
            Sospechoso sospechoso11 = new Sospechoso("Leonardo Fagúndez", 37586241, true, new DateTime(1979, 04, 07));
            Sospechoso sospechoso12 = new Sospechoso("Mariana Costa", 49231578, false, new DateTime(1989, 08, 16));
            Sospechoso sospechoso13 = new Sospechoso("Nicolás Bentancur", 53374816, false, new DateTime(1997, 01, 21));
            Sospechoso sospechoso14 = new Sospechoso("Patricia Acosta", 42857392, true, new DateTime(1984, 03, 11));
            Sospechoso sospechoso15 = new Sospechoso("Sebastián Duarte", 51482639, false, new DateTime(1993, 12, 05));


            // =========================
            // CASO 1
            // =========================

            List<Evidencia> evidenciasCaso1 = new List<Evidencia>
            {
                new Fisica("Huella encontrada sobre la puerta trasera del comercio.", new DateTime(2026, 10, 08), true),
                new Grabacion("Grabación de una cámara exterior del comercio.", new DateTime(2026, 10, 07), 4, true),
                new Testimonio("Declaración de una persona que se encontraba en las inmediaciones.", new DateTime(2026, 10, 09), "Ricardo Morales", Credibilidad.ALTO),
                new Fisica("Fragmento de vidrio encontrado próximo a la puerta.", new DateTime(2026, 04, 15), false)
            };

            Caso caso1 = new Caso("Robo en comercio céntrico", "Robo ocurrido durante la madrugada en un comercio del centro.", false, sospechoso1, detective1, evidenciasCaso1);


            // =========================
            // CASO 2
            // =========================

            List<Evidencia> evidenciasCaso2 = new List<Evidencia>
            {
                new Fisica("Objeto metálico encontrado dentro del vehículo.", new DateTime(2026, 03, 12), false),
                new Grabacion("Registro de una cámara de seguridad de la calle.", new DateTime(2026, 03, 11), 2, false),
                new Testimonio("Declaración de un vecino que observó movimientos sospechosos.", new DateTime(2026, 03, 13), "Laura Fernández", Credibilidad.MEDIO),
                new Grabacion("Grabación de una cámara ubicada en una estación de servicio.", new DateTime(2026, 01, 20), 5, true)
            };

            Caso caso2 = new Caso("Hurto de vehículo", "Denuncia por la desaparición de un vehículo estacionado.", true, sospechoso2, detective2, evidenciasCaso2);


            // =========================
            // CASO 3
            // =========================

            List<Evidencia> evidenciasCaso3 = new List<Evidencia>
            {
                new Fisica("Huella encontrada sobre una ventana de la vivienda.", new DateTime(2026, 10, 03), true),
                new Testimonio("Declaración de un vecino de la vivienda afectada.", new DateTime(2026, 10, 04), "Jorge Pereira", Credibilidad.BAJO),
                new Grabacion("Cámara de seguridad ubicada frente a la vivienda.", new DateTime(2026, 10, 02), 3, false),
                new Fisica("Herramienta encontrada en las proximidades de la vivienda.", new DateTime(2026, 02, 18), false)
            };

            Caso caso3 = new Caso("Asalto a vivienda", "Ingreso no autorizado a una vivienda y sustracción de objetos.", false, sospechoso3, detective3, evidenciasCaso3);


            // =========================
            // CASO 4
            // =========================

            List<Evidencia> evidenciasCaso4 = new List<Evidencia>
            {
                new Fisica("Documento original encontrado durante el registro.", new DateTime(2026, 08, 25), true),
                new Testimonio("Declaración de un funcionario relacionado con la documentación.", new DateTime(2026, 08, 27), "Marcela Rodríguez", Credibilidad.ALTO),
                new Grabacion("Registro audiovisual de una cámara de seguridad.", new DateTime(2026, 08, 26), 1, false),
                new Fisica("Copia de documentación presuntamente adulterada.", new DateTime(2026, 01, 10), false)
            };

            Caso caso4 = new Caso("Fraude documental", "Investigación relacionada con documentación presuntamente adulterada.", true, sospechoso4, detective4, evidenciasCaso4);


            // =========================
            // CASO 5
            // =========================

            List<Evidencia> evidenciasCaso5 = new List<Evidencia>
            {
                new Grabacion("Cámara interna del depósito.", new DateTime(2026, 09, 29), 5, true),
                new Fisica( "Huellas encontradas en una caja de mercadería.", new DateTime(2026, 09, 30), false),
                new Testimonio("Declaración de un empleado del depósito.", new DateTime(2026, 10, 01), "Andrés Silva", Credibilidad.MEDIO),
                new Grabacion( "Registro de una cámara exterior.", new DateTime(2026, 02, 12), 2, false)
            };

            Caso caso5 = new Caso("Robo en depósito", "Sustracción de mercadería desde un depósito comercial.", false, sospechoso5, detective5, evidenciasCaso5);


            // =========================
            // CASO 6
            // =========================

            List<Evidencia> evidenciasCaso6 = new List<Evidencia>
            {
                new Testimonio("Declaración de una persona presente durante la agresión.", new DateTime(2026, 06, 15), "Pablo Suárez", Credibilidad.ALTO),
                new Fisica("Prenda encontrada en el lugar de los hechos.", new DateTime(2026, 06, 15), true),
                new Grabacion("Cámara de seguridad de un comercio cercano.", new DateTime(2026, 06, 16), 4, true),
                new Testimonio("Segunda declaración de una persona que presenció el hecho.", new DateTime(2026, 06, 17), "Natalia Gómez", Credibilidad.BAJO)
            };

            Caso caso6 = new Caso("Agresión en vía pública", "Investigación por una agresión ocurrida en la vía pública.", true, sospechoso7, detective1, evidenciasCaso6);


            // =========================
            // CASO 7
            // =========================

            List<Evidencia> evidenciasCaso7 = new List<Evidencia>
            {
                new Fisica("Recipiente encontrado en las proximidades del lugar del incendio.", new DateTime(2026, 07, 22), false),
                new Grabacion("Cámara de seguridad de un edificio cercano.", new DateTime(2026, 07, 23), 3, false ),
                new Testimonio("Declaración de un vecino que observó a una persona cerca del lugar.", new DateTime(2026, 07, 24), "Sergio Martínez", Credibilidad.MEDIO),
                new Fisica("Fragmentos encontrados en la zona afectada.", new DateTime(2026, 01, 08), true)
            };

            Caso caso7 = new Caso("Incendio intencional", "Investigación sobre un incendio presuntamente provocado.", false, sospechoso8, detective2, evidenciasCaso7);


            // =========================
            // CASO 8
            // =========================

            List<Evidencia> evidenciasCaso8 = new List<Evidencia>
            {
                new Grabacion("Registro de cámara ubicada en el pasillo de la oficina.", new DateTime(2026, 05, 05), 2, false),
                new Fisica( "Huellas encontradas sobre un escritorio.", new DateTime(2026, 05, 06), true),
                new Testimonio("Declaración de un empleado de la oficina.", new DateTime(2026, 05, 07), "Verónica Lima", Credibilidad.ALTO),
                new Grabacion("Cámara ubicada en el acceso principal.", new DateTime(2026, 05, 10), 4, true)
            };

            Caso caso8 = new Caso("Hurto en oficina", "Desaparición de equipos electrónicos desde una oficina.", true, sospechoso9, detective3, evidenciasCaso8);


            // =========================
            // CASO 9
            // =========================

            List<Evidencia> evidenciasCaso9 = new List<Evidencia>
            {
                new Testimonio("Declaración de la persona que recibió las amenazas.", new DateTime(2026, 10, 01), "Daniela Pérez", Credibilidad.ALTO),
                new Grabacion("Grabación obtenida de una cámara del edificio.", new DateTime(2026, 09, 30), 1, false),
                new Fisica("Nota encontrada en el domicilio de la víctima.", new DateTime(2026, 10, 02), false),
                new Testimonio("Declaración de un vecino que escuchó una de las amenazas.", new DateTime(2026, 10, 03), "Héctor González", Credibilidad.MEDIO)
            };

            Caso caso9 = new Caso("Amenazas reiteradas", "Investigación originada por denuncias de amenazas.", false, sospechoso10, detective4, evidenciasCaso9);


            // =========================
            // CASO 10
            // =========================

            List<Evidencia> evidenciasCaso10 = new List<Evidencia>
            {
                new Fisica("Herramienta encontrada en las inmediaciones de la obra.", new DateTime(2026, 03, 18), true),
                new Grabacion("Cámara ubicada en el acceso a la obra.", new DateTime(2026, 03, 17), 5, true),
                new Testimonio("Declaración del encargado de la obra.", new DateTime(2026, 03, 19), "Eduardo Ramírez", Credibilidad.BAJO),
                new Fisica("Marca encontrada sobre una de las herramientas recuperadas.", new DateTime(2026, 03, 20), false)
            };

            Caso caso10 = new Caso("Robo de maquinaria", "Investigación por la desaparición de maquinaria de una obra.", true, sospechoso11, detective5, evidenciasCaso10);


            // =========================
            // AGREGAR DATOS AL SISTEMA
            // =========================

            // Agregar investigadores

            _investigadores.Add(detective1);
            _investigadores.Add(detective2);
            _investigadores.Add(detective3);
            _investigadores.Add(detective4);
            _investigadores.Add(detective5);

            _investigadores.Add(fiscal1);
            _investigadores.Add(fiscal2);
            _investigadores.Add(fiscal3);
            _investigadores.Add(fiscal4);
            _investigadores.Add(fiscal5);

            // Agregar sospechosos
            
            _sospechosos.Add(sospechoso1);
            _sospechosos.Add(sospechoso2);
            _sospechosos.Add(sospechoso3);
            _sospechosos.Add(sospechoso4);
            _sospechosos.Add(sospechoso5);
            _sospechosos.Add(sospechoso6);
            _sospechosos.Add(sospechoso7);
            _sospechosos.Add(sospechoso8);
            _sospechosos.Add(sospechoso9);
            _sospechosos.Add(sospechoso10);
            _sospechosos.Add(sospechoso11);
            _sospechosos.Add(sospechoso12);
            _sospechosos.Add(sospechoso13);
            _sospechosos.Add(sospechoso14);
            _sospechosos.Add(sospechoso15);

            // Agregar casos

            _casos.Add(caso1);
            _casos.Add(caso2);
            _casos.Add(caso3);
            _casos.Add(caso4);
            _casos.Add(caso5);
            _casos.Add(caso6);
            _casos.Add(caso7);
            _casos.Add(caso8);
            _casos.Add(caso9);
            _casos.Add(caso10);

        }

    }
}
