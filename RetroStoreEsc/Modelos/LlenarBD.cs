using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RetroStoreEsc.Servicios;
using RetroStoreEsc.Modelos;

namespace RetroStoreEsc.Modelos
{
    public class LlenarBD
    {
        public LlenarBD()
        {
            ServiceProductos serviceProductos = new ServiceProductos();
            ServiceCategorias serviceCategorias = new ServiceCategorias();
            Categorias categoria = new Categorias();

            categoria.Nombre_Categoria = "Gabinetes";
            serviceCategorias.Insertar(categoria);

            categoria.Nombre_Categoria = "Tarjetas Madre";
            serviceCategorias.Insertar(categoria);

            categoria.Nombre_Categoria = "Procesadores";
            serviceCategorias.Insertar(categoria);

            categoria.Nombre_Categoria = "Tarjetas de Video";
            serviceCategorias.Insertar(categoria);

            categoria.Nombre_Categoria = "Fuentes de Poder";
            serviceCategorias.Insertar(categoria);

            categoria.Nombre_Categoria = "Memorias Ram";
            serviceCategorias.Insertar(categoria);

            categoria.Nombre_Categoria = "Almacenamiento";
            serviceCategorias.Insertar(categoria);

            categoria.Nombre_Categoria = "Refrigeracion";
            serviceCategorias.Insertar(categoria);

            categoria.Nombre_Categoria = "Monitores";
            serviceCategorias.Insertar(categoria);

            categoria.Nombre_Categoria = "Perifericos";
            serviceCategorias.Insertar(categoria);

            //Gabinetes:
            //Producto 1:
            Productos producto = new Productos();
            producto.Id_Categoria = 1;
            producto.Marca = "Aorus";
            producto.Modelo = "AORUS C300 GLASS";
            producto.Descripcion = "Gabinete AORUS C300 GLASS con Ventana RGB, Midi Tower, ATX/Micro ATX/Mini-ITX, USB 3.0, sin Fuente, Negro";
            producto.Caracteristicas = "Factor de forma: Midi-Tower, Tarjetas madre soportadas: ATX,Micro ATX,Mini-ITX, Cantidad de puertos USB 3.0: 2, Fuente de alimentación incluida: No, Disco duro soportado: 2.5', Ventiladores frontales instalados: 1x 120 mm, Ventiladores traseros instalados: 1x 120 mm";
            producto.Precio = 3000;
            producto.Stock = 10;
            serviceProductos.Insertar(producto);

            //Producto 2:
            producto = new Productos();
            producto.Id_Categoria = 1;
            producto.Marca = "Thermaltake";
            producto.Modelo = "Thermaltake Divider 300 TG ARGB";
            producto.Descripcion = "Gabinete Thermaltake Divider 300 TG ARGB con Ventana RGB, Midi Tower, ATX/Micro ATX/Mini-ITX, USB 3.0, sin Fuente, Blanco";
            producto.Caracteristicas = "Factor de forma: Midi-Tower, Cristal Templado: Si, Tarjetas madre soportadas: ATX, Micro ATX, Mini-ITX, Fuente de alimentación incluida: No, Disco duro soportado: 2.5'', Ventiladores frontales instalados: 3x 120 mm, Ventiladores traseros instalados: 1x 120 mm";
            producto.Precio = 3490;
            producto.Stock = 5;
            serviceProductos.Insertar(producto);

            //Producto 3:
            producto = new Productos();
            producto.Id_Categoria = 1;
            producto.Marca = "Aerocool";
            producto.Modelo = "Aerocool Quantum";
            producto.Descripcion = "Gabinete Aerocool Quantum con Ventana RGB, Midi-Tower, ATX/Micro ATX/Mini-ITX, USB 3.0, sin Fuente, Negro";
            producto.Caracteristicas = "Factor de forma: Midi-Tower, Cantidad de puertos USB 2.0: 1";
            producto.Precio = 1179;
            producto.Stock = 6;
            serviceProductos.Insertar(producto);

            //Producto 4:
            producto = new Productos();
            producto.Id_Categoria = 1;
            producto.Marca = "Yeyian";
            producto.Modelo = "Yeyian Kalt 1101";
            producto.Descripcion = "Gabinete Yeyian Kalt 1101 con Ventana LED Azul, Midi-Tower, Micro-ATX, USB 3.1, sin Fuente, Negro";
            producto.Caracteristicas = "Factor de forma: Midi-Tower, Tarjetas madre soportadas: Micro - ATX, Cantidad de puertos USB 2.0: 2";
            producto.Precio = 890;
            producto.Stock = 6;
            serviceProductos.Insertar(producto);

            //Producto 5:
            producto = new Productos();
            producto.Id_Categoria = 1;
            producto.Marca = "Yeyian";
            producto.Modelo = "Yeyian Armageddon 2200 MOD";
            producto.Descripcion = "Gabinete Yeyian Armageddon 2200 MOD con Ventana RGB, Full-Tower, ATX, USB 3.0, sin Fuente, Negro";
            producto.Caracteristicas = "Tarjetas madre soportadas: ATX, Cantidad de puertos USB 2.0: 2";
            producto.Precio = 1319;
            producto.Stock = 8;
            serviceProductos.Insertar(producto);

            //Producto 6:
            producto = new Productos();
            producto.Id_Categoria = 1;
            producto.Marca = "Gigabyte";
            producto.Modelo = "Gigabyte C200";
            producto.Descripcion = "Gabinete Gigabyte C200 con Ventana RGB, Midi-Tower, ATX/Micro-ATX/Mini-ITX, sin Fuente, USB 3.1, Negro";
            producto.Caracteristicas = "Factor de forma: Midi-Tower, Tarjetas madre soportadas: ATX,Micro ATX, Mini-ITX, Cantidad de puertos USB 3.0: 2, Fuente de alimentación incluida: No, Disco duro soportado: 2.5''";
            producto.Precio = 1199;
            producto.Stock = 7;
            serviceProductos.Insertar(producto);

            //Tarjetas Madre:
            //Producto 1:
            producto = new Productos();
            producto.Id_Categoria = 2;
            producto.Marca = "AORUS";
            producto.Modelo = "AORUS ATX B450 Elite V2";
            producto.Descripcion = "Tarjeta Madre AORUS ATX B450 Elite V2, S-AM4, AMD B450, HDMI, 128GB DDR4 para AMD - Requiere Actualización de BIOS para Ryzen Serie 5000";
            producto.Caracteristicas = "Circuito integrado de tarjeta madre: AMD B450, Socket de procesador: Socket AM4, Circuito integrado: AMD B450, Memoria interna, máxima: 128 GB, Tipo de memoria: DDR4-SDRAM";
            producto.Precio = 2300;
            producto.Stock = 11;
            serviceProductos.Insertar(producto);

            //Producto 2:
            producto = new Productos();
            producto.Id_Categoria = 2;
            producto.Marca = "ASUS";
            producto.Modelo = "ASUS ATX ROG STRIX B550-F GAMING";
            producto.Descripcion = "Tarjeta Madre ASUS ATX ROG STRIX B550-F GAMING, S-AM4, AMD B550, HDMI, 128GB DDR4 para AMD ― Requiere Actualización de BIOS para la Serie Ryzen 5000";
            producto.Caracteristicas = "Familia de procesador: AMD, Circuito integrado de tarjeta madre: AMD B550, Socket de procesador: Socket AM4, Circuito integrado: AMD B550, Memoria interna, máxima: 128 GB, Tipo de memoria: DDR4 - SDRAM";
            producto.Precio = 4399;
            producto.Stock = 13;
            serviceProductos.Insertar(producto);

            //Producto 3:
            producto = new Productos();
            producto.Id_Categoria = 2;
            producto.Marca = "Gigabyte";
            producto.Modelo = "Gigabyte ATX B550 Gaming X";
            producto.Descripcion = "Tarjeta Madre Gigabyte ATX B550 Gaming X, S-AM4, AMD B550, HDMI, 128GB DDR4 para AMD ― Requiere Actualización de BIOS para la Serie Ryzen 5000";
            producto.Caracteristicas = "Familia de procesador: AMD, Circuito integrado de tarjeta madre: AMD B550, Socket de procesador: Socket AM4, Circuito integrado: AMD B550, Memoria interna, máxima: 128 GB, Tipo de memoria: DDR4 - SDRAM";
            producto.Precio = 3389;
            producto.Stock = 5;
            serviceProductos.Insertar(producto);

            //Producto 4:
            producto = new Productos();
            producto.Id_Categoria = 2;
            producto.Marca = "ASUS";
            producto.Modelo = "ASUS ATX TUF Gaming B550-PLUS WIFI II";
            producto.Descripcion = "Tarjeta Madre ASUS ATX TUF Gaming B550-PLUS WIFI II, S-AM4, AMD B550, HDMI, 128GB DDR4 para AMD";
            producto.Caracteristicas = "Circuito integrado de tarjeta madre: AMD B550, Socket de procesador: Socket AM4, Circuito integrado: AMD B550, Memoria interna, máxima: 128 GB, Tipo de memoria: DDR4 - SDRAM";
            producto.Precio = 4199;
            producto.Stock = 4;
            serviceProductos.Insertar(producto);

            //Producto 5:
            producto = new Productos();
            producto.Id_Categoria = 2;
            producto.Marca = "MSI";
            producto.Modelo = "MSI ATX MPG B550 GAMING PLUS";
            producto.Descripcion = "Tarjeta Madre MSI ATX MPG B550 GAMING PLUS, S-AM4, AMD B550, HDMI, 128GB DDR4 para AMD ― Requiere Actualización de BIOS para la Serie Ryzen 5000";
            producto.Caracteristicas = "Circuito integrado de tarjeta madre: AMD B550, Socket de procesador: Socket AM4, Circuito integrado: AMD B550, Memoria interna, máxima: 128 GB, Tipo de memoria: DDR4 - SDRAM";
            producto.Precio = 3159;
            producto.Stock = 9;
            serviceProductos.Insertar(producto);

            //Procesadores:
            //Producto 1:
            producto = new Productos();
            producto.Id_Categoria = 3;
            producto.Marca = "Intel";
            producto.Modelo = "Intel Core i5-10400F";
            producto.Descripcion = "Procesador Intel Core i5-10400F, S-1200, 2.90GHz, Six-Core, 12MB Cache (10ma. Generación - Comet Lake) ― Requiere Gráficos Discretos";
            producto.Caracteristicas = "Familia de procesador: Intel® Core™ i5-10xxx, Modelo del procesador: i5 - 10400F, Socket de procesador: LGA 1200, Número de núcleos: 6";
            producto.Precio = 2599;
            producto.Stock = 10;
            serviceProductos.Insertar(producto);

            //Producto 2:
            producto = new Productos();
            producto.Id_Categoria = 3;
            producto.Marca = "Intel";
            producto.Modelo = "Intel Core i9-12900K Intel UHD Graphics 770";
            producto.Descripcion = "Procesador Intel Core i9-12900K Intel UHD Graphics 770, S-1700, 3.20GHz, 16-Core, 30MB Smart Cache (12va. Generación - Alder Lake)";
            producto.Caracteristicas = "Modelo del procesador: i9-12900K, Socket de procesador: LGA 1700, Número de núcleos: 16";
            producto.Precio = 13259;
            producto.Stock = 9;
            serviceProductos.Insertar(producto);

            //Producto 3:
            producto = new Productos();
            producto.Id_Categoria = 3;
            producto.Marca = "Intel";
            producto.Modelo = "Intel Core i7-12700F";
            producto.Descripcion = "Procesador Intel Core i7-12700F, S-1700, 2.10GHz, 12-Core, 25MB Smart Cache (12.ª Generación - Alder Lake)";
            producto.Caracteristicas = "Familia de procesador: Intel® Core™ i7 de 12ma Generación, Modelo del procesador: i7 - 12700F, Socket de procesador: LGA 1700, Número de núcleos: 12";
            producto.Precio = 6779;
            producto.Stock = 11;
            serviceProductos.Insertar(producto);

            //Producto 4:
            producto = new Productos();
            producto.Id_Categoria = 3;
            producto.Marca = "AMD";
            producto.Modelo = "AMD Ryzen 5 5600G con Gráficos Radeon 7";
            producto.Descripcion = "Procesador AMD Ryzen 5 5600G con Gráficos Radeon 7, S-AM4, 3.90GHz, Six-Core, 16MB L3 Caché - incluye Disipador Wraith Stealth";
            producto.Caracteristicas = "";
            producto.Precio = 4279;
            producto.Stock = 15;
            serviceProductos.Insertar(producto);

            //Producto 5:
            producto = new Productos();
            producto.Id_Categoria = 3;
            producto.Marca = "AMD";
            producto.Modelo = "AMD Ryzen 7 5700G";
            producto.Descripcion = "Procesador AMD Ryzen 7 5700G, S-AM4, 3.80GHz, 8-Core, 16MB L3 Caché - incluye Disipador Wraith Stealth";
            producto.Caracteristicas = "";
            producto.Precio = 6249;
            producto.Stock = 14;
            serviceProductos.Insertar(producto);

            //Producto 6:
            producto = new Productos();
            producto.Id_Categoria = 3;
            producto.Marca = "AMD";
            producto.Modelo = "AMD Ryzen 5 5600X";
            producto.Descripcion = "Procesador AMD Ryzen 5 5600X, S-AM4, 3.70GHz, 32MB L3 Cache - incluye Disipador Wraith Stealth";
            producto.Caracteristicas = "";
            producto.Precio = 4369;
            producto.Stock = 9;
            serviceProductos.Insertar(producto);

            //Tarjetas de Video:
            //Producto 1:
            producto = new Productos();
            producto.Id_Categoria = 4;
            producto.Marca = "Gigabyte";
            producto.Modelo = "NVIDIA GeForce GT 730 Rev 3.0";
            producto.Descripcion = "Gigabyte Tarjeta de Video NVIDIA GeForce GT 730 Rev 3.0, 2GB 64-bit GDDR3, PCI Express 2.0";
            producto.Caracteristicas = "Frecuencia del procesador: 902 MHz, Cantidad de puertos HDMI: 1";
            producto.Precio = 1409;
            producto.Stock = 18;
            serviceProductos.Insertar(producto);

            //Producto 2:
            producto = new Productos();
            producto.Id_Categoria = 4;
            producto.Marca = "ASUS";
            producto.Modelo = "AMD Radeon RX 6600";
            producto.Descripcion = "Tarjeta de Video ASUS AMD Radeon RX 6600 8GB 128 bit GDDR6, PCI Express 4.0";
            producto.Caracteristicas = "Frecuencia del procesador: 2044 MHz, Frecuencia boost: 2491 MHz, Cantidad de puertos HDMI: 1, Cantidad de DisplayPorts: 3";
            producto.Precio = 9089;
            producto.Stock = 5;
            serviceProductos.Insertar(producto);

            //Producto 3:
            producto = new Productos();
            producto.Id_Categoria = 4;
            producto.Marca = "MSI";
            producto.Modelo = "NVIDIA GeForce GTX 1660 SUPER VENTUS XS OC";
            producto.Descripcion = "Tarjeta de Video MSI NVIDIA GeForce GTX 1660 SUPER VENTUS XS OC, 6GB 192-bit GDDR6, PCI Express x16 3.0";
            producto.Caracteristicas = "Cantidad de puertos DVI-I: 0";
            producto.Precio = 10239;
            producto.Stock = 5;
            serviceProductos.Insertar(producto);

            //Producto 4:
            producto = new Productos();
            producto.Id_Categoria = 4;
            producto.Marca = "ASUS";
            producto.Modelo = "NVIDIA ROG Strix GeForce RTX 3050 OC Gaming";
            producto.Descripcion = "Tarjeta de Video ASUS NVIDIA ROG Strix GeForce RTX 3050 OC Gaming, 8GB 128-bit GDDR6, PCI Express 4.0";
            producto.Caracteristicas = "Frecuencia boost: 1860 MHz, Núcleos CUDA: 2560, Cantidad de puertos HDMI: 2, Cantidad de DisplayPorts: 3";
            producto.Precio = 10509;
            producto.Stock = 7;
            serviceProductos.Insertar(producto);

            //Producto 5:
            producto = new Productos();
            producto.Id_Categoria = 4;
            producto.Marca = "EVGA";
            producto.Modelo = "NVIDIA GeForce RTX 3090 FTW3 Ultra Gaming";
            producto.Descripcion = "Tarjeta de Video EVGA NVIDIA GeForce RTX 3090 FTW3 Ultra Gaming, 24GB 384 bit GDDR6X, PCI Express x16 4.0";
            producto.Caracteristicas = "Cantidad de puertos DVI-I: 0, Cantidad de DisplayPorts: 3";
            producto.Precio = 47200;
            producto.Stock = 4;
            serviceProductos.Insertar(producto);

            //Fuentes de Poder:
            //Producto 1:
            producto = new Productos();
            producto.Id_Categoria = 5;
            producto.Marca = "Corsair";
            producto.Modelo = "Corsair Modular CX750M 80 PLUS Bronze";
            producto.Descripcion = "Fuente de Poder Corsair Modular CX750M 80 PLUS Bronze, ATX, 120mm, 750W";
            producto.Caracteristicas = "Potencia nominal: 750 W, Diámetro de ventilador: 135 mm, Factor de forma: ATX, Alimentador de energía: 24 - pin ATX, Número de conectores SATA: 2, Certificación 80 PLUS: 80 PLUS Bronze";
            producto.Precio = 1579;
            producto.Stock = 5;
            serviceProductos.Insertar(producto);

            //Producto 2:
            producto = new Productos();
            producto.Id_Categoria = 5;
            producto.Marca = "Gigabyte";
            producto.Modelo = "Gigabyte P750GM 80 PLUS Gold";
            producto.Descripcion = "Fuente de Poder Gigabyte P750GM 80 PLUS Gold, 20+4 pin ATX, 120mm, 750W";
            producto.Caracteristicas = "Potencia nominal: 750 W, Diámetro de ventilador: 12 cm, Factor de forma: ATX, Alimentador de energía: 24 - pin ATX, Número de conectores SATA: 8, Certificación 80 PLUS: 80 PLUS Gold";
            producto.Precio = 1669;
            producto.Stock = 7;
            serviceProductos.Insertar(producto);

            //Producto 3:
            producto = new Productos();
            producto.Id_Categoria = 5;
            producto.Marca = "Gigabyte";
            producto.Modelo = "Gigabyte P550B 80 PLUS Bronze";
            producto.Descripcion = "Fuente de Poder Gigabyte P550B 80 PLUS Bronze, 20+4 pin ATX, 120mm, 550W";
            producto.Caracteristicas = "Potencia nominal: 550 W, Diámetro de ventilador: 12 cm, Factor de forma: ATX, Alimentador de energía: 24 - pin ATX, Número de conectores SATA: 6, Certificación 80 PLUS: 80 PLUS Bronze";
            producto.Precio = 1069;
            producto.Stock = 8;
            serviceProductos.Insertar(producto);

            //Producto 4:
            producto = new Productos();
            producto.Id_Categoria = 5;
            producto.Marca = "Aerocool";
            producto.Modelo = "Aerocool Cylon 700 80 PLUS Bronze";
            producto.Descripcion = "Fuente de Poder Aerocool Cylon 700 80 PLUS Bronze, 20+4 pin ATX, 120mm, 700W";
            producto.Caracteristicas = "Potencia nominal: 700 W, Factor de forma: ATX, Alimentador de energía: 24 - pin ATX, Número de conectores SATA: 5, Certificación 80 PLUS: 80 PLUS Bronze";
            producto.Precio = 1079;
            producto.Stock = 6;
            serviceProductos.Insertar(producto);

            //Memoria RAM:
            //Producto 1:
            producto = new Productos();
            producto.Id_Categoria = 6;
            producto.Marca = "XPG";
            producto.Modelo = "Spectrix D60G DDR4";
            producto.Descripcion = "Memoria Ram XPG Spectrix D60G DDR4, 3200MHz, 8GB, Non-ECC, CL16, XMP";
            producto.Caracteristicas = "Tipo de memoria interna: DDR4, Memoria interna: 8 GB, Diseño de memoria: 1 x 8 GB, Velocidad de memoria del reloj: 3200 MHz, Latencia CAS: 16";
            producto.Precio = 799;
            producto.Stock = 15;
            serviceProductos.Insertar(producto);

            //Producto 2:
            producto = new Productos();
            producto.Id_Categoria = 6;
            producto.Marca = "Corsair";
            producto.Modelo = "Vengeance RGB Pro DDR4";
            producto.Descripcion = "Kit Memoria RAM Corsair Vengeance RGB Pro DDR4, 2666MHz, 16GB (2x8GB), Non ECC, CL16, XMP";
            producto.Caracteristicas = "Memoria interna: 16 GB, Latencia CAS: 16";
            producto.Precio = 1729;
            producto.Stock = 9;
            serviceProductos.Insertar(producto);

            //Producto 3:
            producto = new Productos();
            producto.Id_Categoria = 6;
            producto.Marca = "XPG";
            producto.Modelo = "SPECTRIX D50 RGB Tungsten Grey DDR4";
            producto.Descripcion = "Memoria RAM XPG SPECTRIX D50 RGB Tungsten Grey DDR4, 4133MHz, 8GB, Non-ECC, CL19, XMP";
            producto.Caracteristicas = "Tipo de memoria interna: DDR4, Memoria interna: 8 GB, Diseño de memoria: 1 x 8 GB, Velocidad de memoria del reloj: 4133 MHz, Intel Extreme Memory Profile(XMP): Si";
            producto.Precio = 1069;
            producto.Stock = 8;
            serviceProductos.Insertar(producto);

            //Producto 4:
            producto = new Productos();
            producto.Id_Categoria = 6;
            producto.Marca = "G.Skill";
            producto.Modelo = "Trident Z RGB DDR4";
            producto.Descripcion = "Kit Memoria RAM G.Skill Trident Z RGB DDR4, 3200MHz, 16GB (2 x 8GB), Non-ECC, CL16, XMP";
            producto.Caracteristicas = "Tipo de memoria interna: DDR4, Memoria interna: 16 GB, Diseño de memoria: 2 x 8 GB, Velocidad de memoria del reloj: 3200 MHz, Latencia CAS: 16, Intel Extreme Memory Profile(XMP): Si";
            producto.Precio = 2359;
            producto.Stock = 11;
            serviceProductos.Insertar(producto);

            //Almacenamiento:
            //Producto 1:
            producto = new Productos();
            producto.Id_Categoria = 7;
            producto.Marca = "Seagate";
            producto.Modelo = "Barracuda 3.5''";
            producto.Descripcion = "Disco Duro Interno Seagate Barracuda 3.5'', 2TB, SATA III, 6 Gbit/s, 7200RPM, 256MB Cache";
            producto.Caracteristicas = "Capacidad: 2000 GB, Velocidad de rotación: 7200 RPM, Tamaño de disco duro: 3.5'', Interfaz: Serial ATA III, Velocidad de transferencia: 6 Gbit / s, Tamaño de búfer: 256 MB";
            producto.Precio = 1039;
            producto.Stock = 22;
            serviceProductos.Insertar(producto);

            //Producto 2:
            producto = new Productos();
            producto.Id_Categoria = 7;
            producto.Marca = "Adata";
            producto.Modelo = "SSD Adata Ultimate SU630 QLC 3D";
            producto.Descripcion = "SSD Adata Ultimate SU630 QLC 3D, 240GB, SATA, 2.5'', 7mm";
            producto.Caracteristicas = "Capacidad: 240 GB, Interface: Serial ATA, Velocidad de lectura: 520 MB / s, Velocidad de escritura: 450 MB / s";
            producto.Precio = 539;
            producto.Stock = 15;
            serviceProductos.Insertar(producto);

            //Producto 3:
            producto = new Productos();
            producto.Id_Categoria = 7;
            producto.Marca = "XPG";
            producto.Modelo = "SSD XPG Spectrix S40G";
            producto.Descripcion = "SSD XPG Spectrix S40G, 512GB, PCI Express 3.0, M.2";
            producto.Caracteristicas = "Capacidad: 512 GB, Interface: PCI Express 3.0, Velocidad de lectura: 3500 MB / s, Velocidad de escritura: 3000 MB / s";
            producto.Precio = 1289;
            producto.Stock = 16;
            serviceProductos.Insertar(producto);

            //Producto 4:
            producto = new Productos();
            producto.Id_Categoria = 7;
            producto.Marca = "AORUS";
            producto.Modelo = "SSD AORUS RGB";
            producto.Descripcion = "SSD AORUS RGB, 512GB, PCI Express 3.0, M.2";
            producto.Caracteristicas = "Capacidad: 512 GB, Interface: PCI Express 3.0, Velocidad de lectura: 2480 MB / s, Velocidad de escritura: 2000 MB / s";
            producto.Precio = 1700;
            producto.Stock = 18;
            serviceProductos.Insertar(producto);

            //Refrigeracion:
            //Producto 1:
            producto = new Productos();
            producto.Id_Categoria = 8;
            producto.Marca = "AORUS";
            producto.Modelo = "WATERFORCE X 240 Enfriamiento Líquido para CPU";
            producto.Descripcion = "AORUS WATERFORCE X 240 Enfriamiento Líquido para CPU, 2x 120mm, 800 - 2500RPM";
            producto.Caracteristicas = "Diámetro de ventilador: 12 cm, Número de ventiladores: 2 Ventilador(es), Nivel de ruido: 37.6 Db, Utilizar con: Procesador";
            producto.Precio = 4619;
            producto.Stock = 6;
            serviceProductos.Insertar(producto);

            //Producto 2:
            producto = new Productos();
            producto.Id_Categoria = 8;
            producto.Marca = "Aerocool";
            producto.Modelo = "Mirage L240 Enfriamiento Líquido para CPU";
            producto.Descripcion = "Aerocool Mirage L240 Enfriamiento Líquido para CPU, 2x 120mm, 600-1800RPM, Negro";
            producto.Caracteristicas = "Nivel de ruido: 26.8 Db, Tecnología de rodamientos: Hidráulico, Utilizar con: Procesador";
            producto.Precio = 1859;
            producto.Stock = 6;
            serviceProductos.Insertar(producto);

            //Producto 3:
            producto = new Productos();
            producto.Id_Categoria = 8;
            producto.Marca = "AORUS";
            producto.Modelo = "ATC800 RGB";
            producto.Descripcion = "Disipador CPU Gigabyte AORUS ATC800 RGB, 120mm, 600RPM - 2000RPM, Negro";
            producto.Caracteristicas = "Sockets de procesador soportados: LGA 1150 (Zócalo H3), LGA 1151 (Zócalo H4), LGA 1155 (Socket H2), LGA 1156 (Socket H), LGA 1366 (Socket B), LGA 2011-v3 (Socket R), LGA 2066, Socket AM2, Socket AM3, Socket AM3, Socket AM3+, Socket AM4, Socket FM1, Socket FM2, Socket FM2+";
            producto.Precio = 1969;
            producto.Stock = 10;
            serviceProductos.Insertar(producto);

            //Producto 4:
            producto = new Productos();
            producto.Id_Categoria = 8;
            producto.Marca = "Vetroo";
            producto.Modelo = "Vetroo V5";
            producto.Descripcion = "Disipador CPU Vetroo V5, 120mm, 800 - 1700RPM, Negro";
            producto.Caracteristicas = "Diámetro de ventilador: 12 cm, Velocidad de rotación (máx.)	1700 RPM, Presión máxima de aire  3.61 mmH2O, Mínimo flujo de aire    21 cfm, Sockets de procesador soportados: LGA 1150(Zócalo H3), LGA 1151(Zócalo H4), LGA 1155(Socket H2), LGA 1156(Socket H), LGA 1200(Socket H5), LGA 1700";
            producto.Precio = 729;
            producto.Stock = 12;
            serviceProductos.Insertar(producto);

            //Monitores:
            //Producto 1:
            producto = new Productos();
            producto.Id_Categoria = 9;
            producto.Marca = "Samsung";
            producto.Modelo = "LF24T350FHLXZX LED 24''";
            producto.Descripcion = "Monitor Samsung LF24T350FHLXZX LED 24”, Full HD, Widescreen, FreeSync, HDMI, Negro";
            producto.Caracteristicas = "Conector USB incorporado: No, Salida de auriculares: No, Versión HDMI: 1.4, Puerto DVI: No, Número de puertos HDMI: 1, Cantidad de puertos VGA(D-Sub): 1, Número de colores de la pantalla	16.78 millones de colores, Ángulo de visión, horizontal: 178°, Diagonal de la pantalla 61 cm(24''), Pantalla táctil No, Tipo de pantalla: IPS, Forma de la pantalla: Plana, Máxima velocidad de actualización: 75 Hz, Ángulo de visión, vertical  178°, Razón de contraste(típica) 1000:1, Relación de aspecto nativa  16:9, Tiempo de respuesta: 5 ms, Resolución de la pantalla: 1920 x 1080 Pixeles";
            producto.Precio = 3799;
            producto.Stock = 10;
            serviceProductos.Insertar(producto);

            //Producto 2:
            producto = new Productos();
            producto.Id_Categoria = 9;
            producto.Marca = "MSI";
            producto.Modelo = "Optix G241 LED 23.8''";
            producto.Descripcion = "Monitor Gamer MSI Optix G241 LED 23.8”, Full HD, Widescreen, FreeSync, 144Hz, HDMI, Negro";
            producto.Caracteristicas = "Diagonal de la pantalla: 60,5 cm (23.8”), Tipo HD: Full HD, Resolución: 1920 x 1080 Pixeles, NVIDIA G - Sync: No, AMD FreeSync: Si,Tiempo de respuesta: 1 ms, Velocidad de actualización: 144 Hz, Cantidad de puertos HDMI: 2, Altavoces incorporados: No, Color del producto: Negro";
            producto.Precio = 4429;
            producto.Stock = 9;
            serviceProductos.Insertar(producto);

            //Producto 3:
            producto = new Productos();
            producto.Id_Categoria = 9;
            producto.Marca = "AORUS";
            producto.Modelo = "FV43U LCD 43”";
            producto.Descripcion = "Monitor Gamer AORUS FV43U LCD 43”, 4K Ultra HD, Widescreen, FreeSync, 144Hz, 2x HDMI, Negro";
            producto.Caracteristicas = "Diagonal de la pantalla: 109,2 cm (43”), Tipo HD: 4K Ultra HD, Resolución: 3840 x 2160 Pixeles, Tiempo de respuesta: 1 ms, Velocidad de actualización: 144 Hz, Cantidad de puertos HDMI: 2, Altavoces incorporados: Si, Color del producto: Negro";
            producto.Precio = 26200;
            producto.Stock = 17;
            serviceProductos.Insertar(producto);

            //Perifericos:
            //Producto 1:
            producto = new Productos();
            producto.Id_Categoria = 10;
            producto.Marca = "Corsair";
            producto.Modelo = "K55 RGB PRO";
            producto.Descripcion = "Teclado Gamer Corsair K55 RGB PRO, Alámbrico, Negro (Español)";
            producto.Caracteristicas = "Interfaz del dispositivo: USB, Formato del teclado: Full - size(100 %), Diseño de teclado: QWERTY, Retroiluminación: Si";
            producto.Precio = 769;
            producto.Stock = 15;
            serviceProductos.Insertar(producto);

            //Producto 2:
            producto = new Productos();
            producto.Id_Categoria = 10;
            producto.Marca = "Ocelot";
            producto.Modelo = "OGMK02 RGB";
            producto.Descripcion = "Teclado Gamer Ocelot Gaming OGMK02 RGB, Teclado Mecánico, Switch Azul, Alámbrico, Negro (Español)";
            producto.Caracteristicas = "Idioma del teclado: Español, Interruptor del teclado: Interruptor mecánico, Diseño de teclado: QWERTY, Teclas multimedia: Si";
            producto.Precio = 559;
            producto.Stock = 30;
            serviceProductos.Insertar(producto);

            //Producto 3:
            producto = new Productos();
            producto.Id_Categoria = 10;
            producto.Marca = "Logitech";
            producto.Modelo = "G203 LightSync";
            producto.Descripcion = "Mouse Gamer Logitech Óptico G203 LightSync, Alámbrico, USB, 8000DPI, Azul";
            producto.Caracteristicas = "Altura: 116,6 mm, Anchura: 62,15 mm, Profundidad: 38,2 mm, Peso: 85 g(sólo mouse), Longitud del cable: 2,1 m, Iluminación RGB LIGHTSYNC, 6 botones programables, Resolución: 200 – 8.000 dpi";
            producto.Precio = 297;
            producto.Stock = 20;
            serviceProductos.Insertar(producto);

            //Producto 4:
            producto = new Productos();
            producto.Id_Categoria = 10;
            producto.Marca = "Logitech";
            producto.Modelo = "M280";
            producto.Descripcion = "Mouse Logitech Óptico M280, Inalámbrico, 1000DPI, USB, Azul";
            producto.Caracteristicas = "Comodidad ante todo: el diseño contorneado para la mano derecha del M280 guía tu mano a una posición natural y la superficie de goma blanda mejora el tacto para trabajar cómodamente, Larga duración de Batería: con su diseño eficiente, pasarán hasta 18 meses(3) sin que cambies la batería.Concéntrate en las tareas que realmente importan, Control suave del Cursor: experimenta un seguimiento preciso y una fácil selección de texto con este ratón de ordenador, gracias al sensor óptico avanzado mejorado de Logitech, Plug and Play: el pequeño receptor inalámbrico prácticamente desaparece en el puerto USB del ordenador y proporciona una conexión inalámbrica cómoda y fiable con este ratón de Logitech";
            producto.Precio = 256;
            producto.Stock = 20;
            serviceProductos.Insertar(producto);
        }
    }
}
