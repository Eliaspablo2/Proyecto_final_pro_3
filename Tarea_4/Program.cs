using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System.IO;
using System.Threading;

class prueba_automatizada
{
    static void Main()
    {
        try
        {
            var opciones = new EdgeOptions();
            var driver = new EdgeDriver(opciones);

            string carpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "fotos");

            if (!Directory.Exists(carpeta))
            {
                Directory.CreateDirectory(carpeta);
            }

            driver.Navigate().GoToUrl("https://localhost:7213");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            Capturapantalla(driver, Path.Combine(carpeta, "foto1.png"));

            Thread.Sleep(2000);
            var menuconfi = driver.FindElement(By.Id("menuconfi"));
            menuconfi.Click();
            Thread.Sleep(2000);

            var medicos = driver.FindElement(By.Id("medicos"));
            medicos.Click();
            Thread.Sleep(2000);
            Capturapantalla(driver, Path.Combine(carpeta, "foto2.png"));

            var Mcedula = driver.FindElement(By.Id("cedula"));
            Mcedula.SendKeys("9523687401"); 
            Thread.Sleep(2000);

            var nombresm = driver.FindElement(By.Id("nombre"));
            nombresm.SendKeys("Pabre Billini");
            Thread.Sleep(2000);
 
            var boton = driver.FindElement(By.Id("agregarboton"));
            boton.Click();
            Thread.Sleep(2000);
            Capturapantalla(driver, Path.Combine(carpeta, "foto3.png"));

            var menuconfi1 = driver.FindElement(By.Id("menuconfi"));
            menuconfi1.Click();

            var Estadosp = driver.FindElement(By.Id("estadosp"));
            Estadosp.Click();
            Capturapantalla(driver, Path.Combine(carpeta, "foto4.png"));
            Thread.Sleep(2000);

            var nombrep = driver.FindElement(By.Id("nombreEstado"));
            nombrep.SendKeys("Estado Critico");
            Thread.Sleep(2000);

            var boton1 = driver.FindElement(By.Id("estadoPB"));
            boton1.Click();
            Capturapantalla(driver, Path.Combine(carpeta, "foto5.png"));
            Thread.Sleep(2000);

            var menuconfi2 = driver.FindElement(By.Id("menuconfi"));
            menuconfi2.Click();
            Thread.Sleep(1000);

            var tipoenfer = driver.FindElement(By.Id("tipoenfermedad"));
            tipoenfer.Click();
            Capturapantalla(driver, Path.Combine(carpeta, "foto6.png"));
            Thread.Sleep(1000);

            var nombrec = driver.FindElement(By.Id("nombreCaso"));
            nombrec.SendKeys("Atendido");
            Thread.Sleep(1000);

            var agregarEDC = driver.FindElement(By.Id("agregarEDC"));
            agregarEDC.Click();
            Capturapantalla(driver, Path.Combine(carpeta, "foto7.png"));
            Thread.Sleep(1000);

            var menuC = driver.FindElement(By.Id("menucliente"));
            menuC.Click();
            Thread.Sleep(1000);

            var agregarC = driver.FindElement(By.Id("agregarpaciente"));
            agregarC.Click();
            Capturapantalla(driver, Path.Combine(carpeta, "foto8.png"));
            Thread.Sleep(1000);

            var cedulaP = driver.FindElement(By.Id("cedula"));
            cedulaP.SendKeys("9856470123");
            Thread.Sleep(1000);

            var nombrep1 = driver.FindElement(By.Id("nombre"));
            nombrep1.SendKeys("Pedro Antonio");
            Thread.Sleep(1000);

            var apellidop = driver.FindElement(By.Id("apellido"));
            apellidop.SendKeys("De La Cruz");
            Thread.Sleep(1000);

            var correop = driver.FindElement(By.Id("correo"));
            correop.SendKeys("pedroantonioDLCruz@gmail.com");
            Thread.Sleep(1000);

            var telefonop = driver.FindElement(By.Id("telefono"));
            telefonop.SendKeys("8092563147");
            Thread.Sleep(1000);

            var celularp = driver.FindElement(By.Id("celular"));
            celularp.SendKeys("8291475630");
            Thread.Sleep(1000);

            var direccionp = driver.FindElement(By.Id("direccion"));
            direccionp.SendKeys("La Romana");
            Thread.Sleep(1000);

            var Estadocvp = driver.FindElement(By.Id("EstadoCv"));
            Estadocvp.SendKeys("Casado");
            Thread.Sleep(1000);
            Capturapantalla(driver, Path.Combine(carpeta, "foto9.png"));
            driver.ExecuteScript("window.scrollTo(300, document.body.scrollHeight);");

            var boton3 = driver.FindElement(By.Id("agregarC"));
            boton3.Click();
            Thread.Sleep(1000);

            var modificarP = driver.FindElement(By.Id("editarpaciente"));
            modificarP.Click();
            Capturapantalla(driver, Path.Combine(carpeta, "foto10.png"));
            Thread.Sleep(1000);

            var menuC2 = driver.FindElement(By.Id("menucliente"));
            menuC2.Click();
            Thread.Sleep(1000);

            var Cedulap = driver.FindElement(By.Id("cedulaBuscar"));
            Cedulap.SendKeys("9856470123");
            Thread.Sleep(1000);

            var buscarC = driver.FindElement(By.Id("buscarC"));
            buscarC.Click();
            Capturapantalla(driver, Path.Combine(carpeta, "foto11.png"));
            driver.ExecuteScript("window.scrollTo(300, document.body.scrollHeight);");
            Thread.Sleep(1000);

            var menucita = driver.FindElement(By.Id("menucasos"));
            menucita.Click();
            Thread.Sleep(1000);

            var agregarcita = driver.FindElement(By.Id("agregarcita"));
            agregarcita.Click();
            Capturapantalla(driver, Path.Combine(carpeta, "foto12.png"));
            Thread.Sleep(1000);

            var fechaCita = driver.FindElement(By.Id("fecha_caso"));
            fechaCita.SendKeys("12/11/2013");
            Thread.Sleep(1000);

            var paciente = driver.FindElement(By.Id("paciente"));
            paciente.SendKeys("Pedro Antonio");
            Thread.Sleep(1000);

            var UbiL = driver.FindElement(By.Id("UbicacionLatitud"));
            UbiL.SendKeys("18.4391478876407");
            Thread.Sleep(1000);

            var UbiLo = driver.FindElement(By.Id("UbicacionLongitud"));
            UbiLo.SendKeys("-68.97743734597773");
            Thread.Sleep(1000);

            var EstadoCita = driver.FindElement(By.Id("EstadoC"));
            EstadoCita.SendKeys("Atendido");
            driver.ExecuteScript("window.scrollTo(300, document.body.scrollHeight);");
            Thread.Sleep(1000);

            var medicoA = driver.FindElement(By.Id("MedicoA"));
            medicoA.SendKeys("Pabre Billini");
            Thread.Sleep(1000);

            var estadodep = driver.FindElement(By.Id("EstadoP"));
            estadodep.SendKeys("Enfermedad Grave");
            Thread.Sleep(1000);

            var descripciondeenfer = driver.FindElement(By.Id("DescripcionDeenfermedad"));
            descripciondeenfer.SendKeys("Fibrosis quística");
            driver.ExecuteScript("window.scrollTo(300, document.body.scrollHeight);");
            Capturapantalla(driver, Path.Combine(carpeta, "foto13.png"));
            Thread.Sleep(3000);

            var boton4 = driver.FindElement(By.Id("agregarboton"));
            boton4.Click();
            Thread.Sleep(20000);

            var editarcita = driver.FindElement(By.Id("editarcita"));
            editarcita.Click();
            Capturapantalla(driver, Path.Combine(carpeta, "foto14.png"));
            Thread.Sleep(1000);

            var buscarc = driver.FindElement(By.Id("idCasoBuscar"));
            buscarc.SendKeys("202300001");
            Thread.Sleep(1000);

            var boton5 = driver.FindElement(By.Id("buscacit"));
            boton5.Click();
            driver.ExecuteScript("window.scrollTo(300, document.body.scrollHeight);");
            Capturapantalla(driver, Path.Combine(carpeta, "foto15.png"));
            Thread.Sleep(1000);

            var menureporte = driver.FindElement(By.Id("menureporte"));
            menureporte.Click();
            Thread.Sleep(3000);

            var reporte = driver.FindElement(By.Id("reportes"));
            reporte.Click();
            Capturapantalla(driver, Path.Combine(carpeta, "foto16.png"));
            Thread.Sleep(3000);

            var actualizar = driver.FindElement(By.Id("actualizarboton"));
            actualizar.Click();
            driver.ExecuteScript("window.scrollTo(300, document.body.scrollWidth);");
            Thread.Sleep(3000);
            Capturapantalla(driver, Path.Combine(carpeta, "foto17.png"));
            Thread.Sleep(3000);

            var botonhtml = driver.FindElement(By.Id("botonhtml"));
            botonhtml.Click();
            Thread.Sleep(9000);
            Capturapantalla(driver, Path.Combine(carpeta, "foto18.png"));
            Thread.Sleep(3000);

            driver.Navigate().GoToUrl("https://localhost:7213");
            Thread.Sleep(3000);

            var menureporte2 = driver.FindElement(By.Id("menureporte"));
            menureporte2.Click();
            Thread.Sleep(1000);

            var mapa = driver.FindElement(By.Id("mapa"));
            mapa.Click();
            driver.Navigate().Refresh();
            Capturapantalla(driver, Path.Combine(carpeta, "foto19.png"));
            Thread.Sleep(1000);

            var boton6 = driver.FindElement(By.Id("botonmapa"));
            boton6.Click();
            Capturapantalla(driver, Path.Combine(carpeta, "foto20.png"));
            Thread.Sleep(1000);

            var salir = driver.FindElement(By.Id("salir"));
            salir.Click();
            Thread.Sleep(1000);

            driver.Quit();


            // Obtener la ruta completa del informe HTML
            Generarhtml(carpeta);
            string reportepath = Path.Combine(carpeta, "Reporte_final1.html");
            Console.WriteLine($"Informe HTML creado en: {carpeta}");

            // Abrir el informe HTML con el programa predeterminado (normalmente el navegador web)
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = reportepath,
                UseShellExecute = true
            });

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocurrió un error: {ex.Message}");
        }
    }

    // Función para capturar la pantalla y guardarla en un archivo
    static void Capturapantalla(IWebDriver driver, string Path)
    {
        try
        {
            ITakesScreenshot controladorCaptura = (ITakesScreenshot)driver;
            Screenshot Captura = controladorCaptura.GetScreenshot();
            Captura.SaveAsFile(Path, ScreenshotImageFormat.Png);
            Console.WriteLine($"Captura de pantalla guardada en: {Path}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al capturar la pantalla: {ex.Message}");
        }
    }

    static void Generarhtml(string carpeta)
    {
        try
        {
            string reportepath = Path.Combine(carpeta, "Reporte_final1.html");

            using (StreamWriter sw = new StreamWriter(reportepath))
            {
                sw.WriteLine("<html>");
                sw.WriteLine("<head>");
                sw.WriteLine("<title>Reporte Final</title>");
                sw.WriteLine("<style>");
                sw.WriteLine("body { background-color: black; color: white; }");  // Fondo negro y color de texto blanco
                sw.WriteLine(".image-container { margin-bottom: 20px; border: 2px solid white; padding: 10px; }");  // Cuadro alrededor de cada imagen
                sw.WriteLine("</style>");
                sw.WriteLine("</head>");
                sw.WriteLine("<body>");

                sw.WriteLine("<br><center><h1>Informe Final de Prueba Automatizada:</h1></center><hr><br>");

                string[] imagenes = Directory.GetFiles(carpeta, "*.png");

                // Array de textos asociados a cada imagen (asegúrate de que haya tantos elementos como imágenes)
                string[] textos = new string[]
                {
                    "1- Ingreso al proyecto.",
                    "2- Ingresar medico.",
                    "3- Ingresar medico correctamente.",
                    "4- Ingresar a Estado de Paciente.",
                    "5- Ingresr correctmente a Estado de Paciente",
                    "6- Ingresar Estado de cita",
                    "7- Ingresar Correctamente a Estado de Cita",
                    "8- Ingresar paciente" ,
                    "9- Ingresar correctamente el paciente.",
                    "10- Editar paciente",
                    "11- Editar paciente Correctamente",
                    "12- Ingresar Cita",
                    "13- Ingresar Cita Correctamente",
                    "14- Editar Cita",
                    "15- Editar Cita Correctamente",
                    "16- Ingrso a Registros",
                    "17- Registros creado con exito",
                    "18- HTML creado con exito",
                    "19- Mapa" ,
                    "20- Mapa creado",
                };

                // Verificar si la cantidad de textos coincide con la cantidad de imágenes
                if (imagenes.Length == textos.Length)
                {
                    for (int i = 0; i < imagenes.Length; i++)
                    {
                        sw.WriteLine("<div class='image-container'>");

                        // Agregar la imagen recortada
                        sw.WriteLine($"<center><img src=\"{Path.GetFileName(imagenes[i])}\" alt=\"Captura de pantalla\" style='max-width: calc(100% - 20px); max-height: calc(100vh - 80px);'></center>");

                        // Agregar el texto
                        sw.WriteLine($"<p>{textos[i]}</p>");

                        sw.WriteLine("</div>");
                    }
                }
                else
                {
                    sw.WriteLine("<p style='color: red;'>Error: La cantidad de imágenes y textos no coincide.</p>");
                }

                sw.WriteLine("</body>");
                sw.WriteLine("</html>");
            }
            Console.WriteLine($"Informe HTML creado en: {reportepath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al generar el informe HTML: {ex.Message}");
        }
    }
}
