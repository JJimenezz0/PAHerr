using System;
using System.Threading;

namespace AboutPropio
{
	class Program
	{
		
		static void Main()
		{
			//Generales
			Console.Title = "GHOSTIGHT";
			Console.CursorVisible = false;
			Console.Clear();
			Console.SetCursorPosition(0, 0);
			Console.ForegroundColor = ConsoleColor.Black;
			Console.BackgroundColor = ConsoleColor.DarkGray;
			Console.SetWindowSize(100, 45);
			Console.ReadKey();
			
			string nombre, tit_SPN, m1_SPN, m2_SPN, m3_SPN, m4_SPN, m5_SPN, m6_SPN, m7_SPN, m8_SPN, m9_SPN, m10_SPN, m11_SPN, m12_SPN, m13_SPN;
			//Vars
			char sexo, calificacion_cliente;
			string dcliente_SPN, ms;
			uint cel, num_cliente, doc, num_pedido;
			float saldo, peso, altura;
			int debe;
			bool cliente_actual, cliente_atrasado;
			
			//Background
			//caja principal
			Console.SetCursorPosition(1, 0);
			Console.WriteLine("┌─────────────────────────────────────────────────────────────────────────────┐");
			Console.SetCursorPosition(1, 1);
			Console.WriteLine("│                                                                             │");
			Console.SetCursorPosition(1, 2);
			Console.WriteLine("│                                                                             │");
			Console.SetCursorPosition(1, 3);
			Console.WriteLine("│                                                                             │");
			Console.SetCursorPosition(1, 4);
			Console.WriteLine("│                                                                             │");
			Console.SetCursorPosition(1, 5);
			Console.WriteLine("│                                                                             │");
			Console.SetCursorPosition(1, 6);
			Console.WriteLine("│                                                                             │");
			Console.SetCursorPosition(1, 7);
			Console.WriteLine("│                                                                             │");
			Console.SetCursorPosition(1, 8);
			Console.WriteLine("│                                                                             │");
			Console.SetCursorPosition(1, 9);
			Console.WriteLine("│                                                                             │");
			Console.SetCursorPosition(1, 10);
			Console.WriteLine("│                                                                             │");
			Console.SetCursorPosition(1, 11);
			Console.WriteLine("│                                                                             │");
			Console.SetCursorPosition(1, 12);
			Console.WriteLine("│                                                                             │");
			Console.SetCursorPosition(1, 13);
			Console.WriteLine("│                                                                             │");
			Console.SetCursorPosition(1, 14);
			Console.WriteLine("│                                                                             │");
			Console.SetCursorPosition(1, 15);
			Console.WriteLine("│                                                                             │");
			Console.SetCursorPosition(1, 16);
			Console.WriteLine("│                                                                             │");
			Console.SetCursorPosition(1, 17);
			Console.WriteLine("│                                                                             │");
			Console.SetCursorPosition(1, 18);
			Console.WriteLine("│                                                                             │");
			Console.SetCursorPosition(1, 19);
			Console.WriteLine("│                                                                             │");
			Console.SetCursorPosition(1, 20);
			Console.WriteLine("│                                                                             │");
			Console.SetCursorPosition(1, 21);
			Console.WriteLine("│                                                                             │");
			Console.SetCursorPosition(1, 22);
			Console.WriteLine("│                                                                             │");
			Console.SetCursorPosition(1, 23);
			Console.WriteLine("│                                                                             │");
			Console.SetCursorPosition(1, 24);
			Console.WriteLine("│                                                                             │");
			Console.SetCursorPosition(1, 25);
			Console.WriteLine("│                                                                             │");
			Console.SetCursorPosition(1, 26);
			Console.WriteLine("│                                                                             │");
			Console.SetCursorPosition(1, 27);
			Console.WriteLine("│                                                                             │");
			Console.SetCursorPosition(1, 28);
			Console.WriteLine("│                                                                             │");
			Console.SetCursorPosition(1, 29);
			Console.WriteLine("│                                                                             │");
			Console.SetCursorPosition(1, 30);
			Console.WriteLine("│                                                                             │");
			Console.SetCursorPosition(1, 31);
			Console.WriteLine("│                                                                             │");
			Console.SetCursorPosition(1, 32);
			Console.WriteLine("│                                                                             │");
			Console.SetCursorPosition(1, 33);
			Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────┘");
			
			//Titulo
			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.SetCursorPosition(50, 2);
			tit_SPN = "INGRESAR DATOS";
			Console.WriteLine(tit_SPN);
			
			//barra superior
			Console.SetCursorPosition(2, 0);
			Console.ForegroundColor = ConsoleColor.Black;
			Console.BackgroundColor = ConsoleColor.DarkRed;
			Console.WriteLine("                                Formulario                                 X ");
			
			//Fromularios
			Console.ForegroundColor = ConsoleColor.Black;
			Console.BackgroundColor = ConsoleColor.DarkGray;
			Console.SetCursorPosition(5, 3);
			m1_SPN = "Nombre/s:              ";
			Console.WriteLine(m1_SPN);
			Console.SetCursorPosition(5, 5);
			m2_SPN = "Número de documento:   ";
			Console.WriteLine(m2_SPN);
			Console.SetCursorPosition(5, 7);
			m3_SPN = "Número de cliente:     ";
			Console.WriteLine(m3_SPN);
			Console.SetCursorPosition(5, 9);
			m4_SPN = "Número de pedido:      ";
			Console.WriteLine(m4_SPN);
			Console.SetCursorPosition(5, 11);
			m5_SPN = "Celular:               ";
			Console.WriteLine(m5_SPN);
			Console.SetCursorPosition(5, 13);
			m6_SPN = "Sexo del cliente:      ";
			Console.WriteLine(m6_SPN);
			Console.SetCursorPosition(5, 15);
			m7_SPN = "Calificación cliente:  ";
			Console.WriteLine(m7_SPN);
			Console.SetCursorPosition(5, 17);
			m8_SPN = "Peso en KG:            ";
			Console.WriteLine(m8_SPN);
			Console.SetCursorPosition(5, 19);
			m9_SPN = "Altura en CM:          ";
			Console.WriteLine(m9_SPN);
			Console.SetCursorPosition(5, 21);
			m10_SPN = "Es Cliente actual:     ";
			Console.WriteLine(m10_SPN);
			Console.SetCursorPosition(5, 23);
			m11_SPN = "Está atrasado:         ";
			Console.WriteLine(m11_SPN);
			Console.SetCursorPosition(5, 25);
			m12_SPN = "El cliente debe:       ";
			Console.WriteLine(m12_SPN);
			Console.SetCursorPosition(5, 27);
			m13_SPN = "Saldo:                 ";
			Console.WriteLine(m13_SPN);
			
			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.SetCursorPosition(28, 3);
			Console.WriteLine("█████████████████████████████████████");
			Console.SetCursorPosition(28, 5);
			Console.WriteLine("█████████████████████████████████████");
			Console.SetCursorPosition(28, 7);
			Console.WriteLine("█████████████████████████████████████");
			Console.SetCursorPosition(28, 9);
			Console.WriteLine("█████████████████████████████████████");
			Console.SetCursorPosition(28, 11);
			Console.WriteLine("█████████████████████████████████████");
			Console.SetCursorPosition(28, 13);
			Console.WriteLine("█████████████████████████████████████");
			Console.SetCursorPosition(28, 15);
			Console.WriteLine("█████████████████████████████████████");
			Console.SetCursorPosition(28, 17);
			Console.WriteLine("█████████████████████████████████████");
			Console.SetCursorPosition(28, 19);
			Console.WriteLine("█████████████████████████████████████");
			Console.SetCursorPosition(28, 21);
			Console.WriteLine("█████████████████████████████████████");
			Console.SetCursorPosition(28, 23);
			Console.WriteLine("█████████████████████████████████████");
			Console.SetCursorPosition(28, 25);
			Console.WriteLine("█████████████████████████████████████");
			Console.SetCursorPosition(28, 27);
			Console.WriteLine("█████████████████████████████████████");
			
			//Boton submit
			Console.ForegroundColor = ConsoleColor.Red;
			Console.BackgroundColor = ConsoleColor.Black;
			Console.SetCursorPosition(66, 8);
			Console.WriteLine("████████████");
			Console.SetCursorPosition(66, 9);
			Console.WriteLine("████████████");
			Console.SetCursorPosition(66, 10);
			Console.WriteLine("████████████");
			Console.SetCursorPosition(69, 9);
			Console.ForegroundColor = ConsoleColor.Black;
			Console.BackgroundColor = ConsoleColor.Red;
			Console.WriteLine("ENVIAR");
			
			//sombra Boton submit ▀
			Console.SetCursorPosition(67, 11);
			Console.ForegroundColor = ConsoleColor.Black;
			Console.BackgroundColor = ConsoleColor.DarkGray;
			Console.WriteLine("▀▀▀▀▀▀▀▀▀▀▀▀");
			Console.ForegroundColor = ConsoleColor.Black;
			Console.BackgroundColor = ConsoleColor.Black;
			Console.SetCursorPosition(78, 10);
			Console.WriteLine("▀");
			Console.SetCursorPosition(78, 9);
			Console.WriteLine("▀");
			Console.ForegroundColor = ConsoleColor.DarkGray;
			Console.SetCursorPosition(78, 8);
			Console.WriteLine("▀");
			
			//boton Actualizar
			Console.ForegroundColor = ConsoleColor.Red;
			Console.BackgroundColor = ConsoleColor.Black;
			Console.SetCursorPosition(66, 16);
			Console.WriteLine("████████████");
			Console.SetCursorPosition(66, 17);
			Console.WriteLine("████████████");
			Console.SetCursorPosition(66, 18);
			Console.WriteLine("████████████");
			Console.SetCursorPosition(67, 17);
			Console.ForegroundColor = ConsoleColor.Black;
			Console.BackgroundColor = ConsoleColor.Red;
			Console.WriteLine("Actualizar");
			
			//sombra Boton actualizar ▀
			Console.SetCursorPosition(67, 19);
			Console.ForegroundColor = ConsoleColor.Black;
			Console.BackgroundColor = ConsoleColor.DarkGray;
			Console.WriteLine("▀▀▀▀▀▀▀▀▀▀▀▀");
			Console.ForegroundColor = ConsoleColor.Black;
			Console.BackgroundColor = ConsoleColor.Black;
			Console.SetCursorPosition(78, 18);
			Console.WriteLine("▀");
			Console.SetCursorPosition(78, 17);
			Console.WriteLine("▀");
			Console.ForegroundColor = ConsoleColor.DarkGray;
			Console.SetCursorPosition(78, 16);
			Console.WriteLine("▀");
			
			//Ingreso de datos
			Console.CursorVisible = true;
			Console.ForegroundColor = ConsoleColor.Black;
			Console.BackgroundColor = ConsoleColor.DarkRed;
			Console.SetCursorPosition(28, 3);
			nombre = Console.ReadLine();
			
			Console.SetCursorPosition(28, 5);
			doc = Convert.ToUInt32(Console.ReadLine());
			
			Console.SetCursorPosition(28, 7);
			num_cliente = Convert.ToUInt32(Console.ReadLine());
			
			Console.SetCursorPosition(28, 9);
			num_pedido = Convert.ToUInt32(Console.ReadLine());
			
			Console.SetCursorPosition(28, 11);
			cel = Convert.ToUInt32(Console.ReadLine());
			
			Console.SetCursorPosition(28, 13);
			sexo = Convert.ToChar(Console.ReadLine());
			
			Console.SetCursorPosition(28, 15);
			calificacion_cliente = Convert.ToChar(Console.ReadLine());
			
			Console.SetCursorPosition(28, 17);
			peso = Convert.ToSingle(Console.ReadLine());
			
			Console.SetCursorPosition(28, 19);
			altura = Convert.ToSingle(Console.ReadLine());
			
			Console.SetCursorPosition(28, 21);
			cliente_actual = Convert.ToBoolean(Console.ReadLine());
			
			Console.SetCursorPosition(28, 23);
			cliente_atrasado = Convert.ToBoolean(Console.ReadLine());
			
			Console.SetCursorPosition(28, 25);
			debe = Convert.ToInt32(Console.ReadLine());
			
			Console.SetCursorPosition(28, 27);
			saldo = Convert.ToInt32(Console.ReadLine());
			
			Console.CursorVisible = false;
			
			//Animación boton submit
			Console.ReadKey();
			Thread.Sleep(1000);
			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.BackgroundColor = ConsoleColor.Black;
			Console.SetCursorPosition(66, 8);
			Console.WriteLine("████████████");
			Console.SetCursorPosition(66, 9);
			Console.WriteLine("████████████");
			Console.SetCursorPosition(66, 10);
			Console.WriteLine("████████████");
			Console.SetCursorPosition(69, 9);
			Console.ForegroundColor = ConsoleColor.Black;
			Console.BackgroundColor = ConsoleColor.DarkRed;
			Console.WriteLine("ENVIAR");
			
			Thread.Sleep(1000);
			Console.ForegroundColor = ConsoleColor.Red;
			Console.BackgroundColor = ConsoleColor.Black;
			Console.SetCursorPosition(66, 8);
			Console.WriteLine("████████████");
			Console.SetCursorPosition(66, 9);
			Console.WriteLine("████████████");
			Console.SetCursorPosition(66, 10);
			Console.WriteLine("████████████");
			Console.SetCursorPosition(69, 9);
			Console.ForegroundColor = ConsoleColor.Black;
			Console.BackgroundColor = ConsoleColor.Red;
			Console.WriteLine("ENVIAR");
			
			Console.ReadKey();
			
			//Resultado form
			Console.ForegroundColor = ConsoleColor.Black;
			Console.BackgroundColor = ConsoleColor.DarkGray;
			Console.SetCursorPosition(86, 2);
			Console.WriteLine("┌───────────────────────────────────────┐");
			Console.SetCursorPosition(86, 3);
			Console.WriteLine("│                                       │");
			Console.SetCursorPosition(86, 4);
			Console.WriteLine("│                                       │");
			Console.SetCursorPosition(86, 5);
			Console.WriteLine("│                                       │");
			Console.SetCursorPosition(86, 6);
			Console.WriteLine("│                                       │");
			Console.SetCursorPosition(86, 7);
			Console.WriteLine("│                                       │");
			Console.SetCursorPosition(86, 8);
			Console.WriteLine("│                                       │");
			Console.SetCursorPosition(86, 9);
			Console.WriteLine("│                                       │");
			Console.SetCursorPosition(86, 10);
			Console.WriteLine("│                                       │");
			Console.SetCursorPosition(86, 11);
			Console.WriteLine("│                                       │");
			Console.SetCursorPosition(86, 12);
			Console.WriteLine("│                                       │");
			Console.SetCursorPosition(86, 13);
			Console.WriteLine("│                                       │");
			Console.SetCursorPosition(86, 14);
			Console.WriteLine("│                                       │");
			Console.SetCursorPosition(86, 15);
			Console.WriteLine("│                                       │");
			Console.SetCursorPosition(86, 16);
			Console.WriteLine("│                                       │");
			Console.SetCursorPosition(86, 17);
			Console.WriteLine("│                                       │");
			Console.SetCursorPosition(86, 18);
			Console.WriteLine("│                                       │");
			Console.SetCursorPosition(86, 19);
			Console.WriteLine("│                                       │");
			Console.SetCursorPosition(86, 20);
			Console.WriteLine("│                                       │");
			Console.SetCursorPosition(86, 21);
			Console.WriteLine("│                                       │");
			Console.SetCursorPosition(86, 22);
			Console.WriteLine("│                                       │");
			Console.SetCursorPosition(86, 23);
			Console.WriteLine("│                                       │");
			Console.SetCursorPosition(86, 24);
			Console.WriteLine("│                                       │");
			Console.SetCursorPosition(86, 25);
			Console.WriteLine("│                                       │");
			Console.SetCursorPosition(86, 26);
			Console.WriteLine("│                                       │");
			Console.SetCursorPosition(86, 27);
			Console.WriteLine("│                                       │");
			Console.SetCursorPosition(86, 28);
			Console.WriteLine("│                                       │");
			Console.SetCursorPosition(86, 29);
			Console.WriteLine("│                                       │");
			Console.SetCursorPosition(86, 30);
			Console.WriteLine("└───────────────────────────────────────┘");
			
			dcliente_SPN = "DATOS DEL CLIENTE";
			Console.SetCursorPosition(88, 3);
			Console.WriteLine(dcliente_SPN);
			
			//Salida de datos
			Console.ForegroundColor = ConsoleColor.Black;
			Console.BackgroundColor = ConsoleColor.DarkGray;
			
			ms = m1_SPN + nombre;
			Console.SetCursorPosition(88, 5);
			Console.WriteLine(ms);
			
			ms = m2_SPN + doc;
			Console.SetCursorPosition(88, 7);
			Console.WriteLine(ms);
			
			ms = m3_SPN + num_cliente;
			Console.SetCursorPosition(88, 9);
			Console.WriteLine(ms);
			
			ms = m4_SPN + num_pedido;
			Console.SetCursorPosition(88, 11);
			Console.WriteLine(ms);
			
			ms = m5_SPN + cel;
			Console.SetCursorPosition(88, 13);
			Console.WriteLine(ms);
			
			ms = m6_SPN + sexo;
			Console.SetCursorPosition(88, 15);
			Console.WriteLine(ms);
			
			ms = m7_SPN + calificacion_cliente;
			Console.SetCursorPosition(88, 17);
			Console.WriteLine(ms);
			
			ms = m8_SPN + peso;
			Console.SetCursorPosition(88, 19);
			Console.WriteLine(ms);
			
			ms = m9_SPN + altura;
			Console.SetCursorPosition(88, 21);
			Console.WriteLine(ms);
			
			ms = m10_SPN + cliente_actual;
			Console.SetCursorPosition(88, 23);
			Console.WriteLine(ms);
			
			ms = m11_SPN + cliente_atrasado;
			Console.SetCursorPosition(88, 25);
			Console.WriteLine(ms);
			
			ms = m12_SPN + debe;
			Console.SetCursorPosition(88, 27);
			Console.WriteLine(ms);
			
			ms = m13_SPN + saldo;
			Console.SetCursorPosition(88, 29);
			Console.WriteLine(ms);
			
			//Animación boton Actualizar
			Console.ReadKey();
			Thread.Sleep(1000);
			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.BackgroundColor = ConsoleColor.Black;
			Console.SetCursorPosition(66, 16);
			Console.WriteLine("████████████");
			Console.SetCursorPosition(66, 17);
			Console.WriteLine("████████████");
			Console.SetCursorPosition(66, 18);
			Console.WriteLine("████████████");
			Console.SetCursorPosition(67, 17);
			Console.ForegroundColor = ConsoleColor.Black;
			Console.BackgroundColor = ConsoleColor.DarkRed;
			Console.WriteLine("Actualizar");
			
			Thread.Sleep(1000);
			Console.ForegroundColor = ConsoleColor.Red;
			Console.BackgroundColor = ConsoleColor.Black;
			Console.SetCursorPosition(66, 16);
			Console.WriteLine("████████████");
			Console.SetCursorPosition(66, 17);
			Console.WriteLine("████████████");
			Console.SetCursorPosition(66, 18);
			Console.WriteLine("████████████");
			Console.SetCursorPosition(67, 17);
			Console.ForegroundColor = ConsoleColor.Black;
			Console.BackgroundColor = ConsoleColor.Red;
			Console.WriteLine("Actualizar");
			
			//About
			//Cajas Principa
			Console.ForegroundColor = ConsoleColor.Black;
			Console.BackgroundColor = ConsoleColor.DarkGray;
			Console.SetCursorPosition(35, 1);
			Console.WriteLine("┌──────────────────────────────────────────────────────────────────────────┐");
			Console.SetCursorPosition(35, 2);
			Console.WriteLine("│                                                                          │");
			Console.SetCursorPosition(35, 3);
			Console.WriteLine("│                                                                          │");
			Console.SetCursorPosition(35, 4);
			Console.WriteLine("│                                                                          │");
			Console.SetCursorPosition(35, 5);
			Console.WriteLine("│                                                                          │");
			Console.SetCursorPosition(35, 6);
			Console.WriteLine("│                                                                          │");
			Console.SetCursorPosition(35, 7);
			Console.WriteLine("│                                                                          │");
			Console.SetCursorPosition(35, 8);
			Console.WriteLine("│                                                                          │");
			Console.SetCursorPosition(35, 9);
			Console.WriteLine("│                                                                          │");
			Console.SetCursorPosition(35, 10);
			Console.WriteLine("│                                                                          │");
			Console.SetCursorPosition(35, 11);
			Console.WriteLine("│                                                                          │");
			Console.SetCursorPosition(35, 12);
			Console.WriteLine("│                                                                          │");
			Console.SetCursorPosition(35, 13);
			Console.WriteLine("│                                                                          │");
			Console.SetCursorPosition(35, 14);
			Console.WriteLine("│                                                                          │");
			Console.SetCursorPosition(35, 15);
			Console.WriteLine("│                                                                          │");
			Console.SetCursorPosition(35, 16);
			Console.WriteLine("│                                                                          │");
			Console.SetCursorPosition(35, 17);
			Console.WriteLine("│                                                                          │");
			Console.SetCursorPosition(35, 18);
			Console.WriteLine("│                                                                          │");
			Console.SetCursorPosition(35, 19);
			Console.WriteLine("│                                                                          │");
			Console.SetCursorPosition(35, 20);
			Console.WriteLine("│                                                                          │");
			Console.SetCursorPosition(35, 21);
			Console.WriteLine("│                                                                          │");
			Console.SetCursorPosition(35, 22);
			Console.WriteLine("└──────────────────────────────────────────────────────────────────────────┘");
			
			
			
			//-------------------------------------------------------------------- Logo -----------------------------------------------------
			
			
			
			Console.ForegroundColor = ConsoleColor.Black;
			Console.SetCursorPosition(52, 20);
			Console.WriteLine("©Ghostight");
			
			Console.ForegroundColor = ConsoleColor.Black;
			//parte 1º superior
			Console.SetCursorPosition(50, 3);
			Console.WriteLine("██");
			Console.SetCursorPosition(52, 3);
			Console.WriteLine("██");
			Console.SetCursorPosition(54, 3);
			Console.WriteLine("██");
			Console.SetCursorPosition(56, 3);
			Console.WriteLine("██");
			Console.SetCursorPosition(58, 3);
			Console.WriteLine("██");
			Console.SetCursorPosition(60, 3);
			Console.WriteLine("██");
			
			//parte 2º linea
			Console.SetCursorPosition(48, 4);
			Console.WriteLine("██");
			Console.SetCursorPosition(46, 4);
			Console.WriteLine("██");
			Console.SetCursorPosition(62, 4);
			Console.WriteLine("██");
			Console.SetCursorPosition(64, 4);
			Console.WriteLine("██");
			
			//parte 3º linea
			Console.SetCursorPosition(44, 5);
			Console.WriteLine("██");
			Console.SetCursorPosition(66, 5);
			Console.WriteLine("██");
			
			//parte 4º linea
			Console.SetCursorPosition(42, 6);
			Console.WriteLine("██");
			Console.SetCursorPosition(68, 6);
			Console.WriteLine("██");
			
			//color NV5
			Console.ForegroundColor = ConsoleColor.White;
			Console.SetCursorPosition(44, 7);
			Console.WriteLine("██  ██  ██████████████████");
			
			//5º linea
			Console.ForegroundColor = ConsoleColor.Black;
			Console.SetCursorPosition(42, 7);
			Console.WriteLine("██");
			Console.SetCursorPosition(70, 7);
			Console.WriteLine("██");
			//ojos
			Console.SetCursorPosition(46, 7);
			Console.WriteLine("██");
			Console.SetCursorPosition(50, 7	);
			Console.WriteLine("██");
			
			//color NV6
			Console.ForegroundColor = ConsoleColor.White;
			Console.SetCursorPosition(42, 8);
			Console.WriteLine("██████████████████████████████");
			
			
			//6º linea
			Console.ForegroundColor = ConsoleColor.Black;
			Console.SetCursorPosition(40, 8);
			Console.WriteLine("██");
			Console.SetCursorPosition(72, 8);
			Console.WriteLine("██");
			//ojos
			Console.SetCursorPosition(46, 8);
			Console.WriteLine("██");
			Console.SetCursorPosition(50, 8);
			Console.WriteLine("██");
			//ala
			Console.SetCursorPosition(62, 8);
			Console.WriteLine("██");
			Console.SetCursorPosition(64, 8);
			Console.WriteLine("██");
			Console.SetCursorPosition(66, 8);
			Console.WriteLine("██");
			
			//color NV7
			Console.ForegroundColor = ConsoleColor.White;
			Console.SetCursorPosition(42, 9);
			Console.WriteLine("██████████████████████████████");
			
			//7º
			Console.ForegroundColor = ConsoleColor.Black;
			Console.SetCursorPosition(40, 9);
			Console.WriteLine("██");
			Console.SetCursorPosition(72, 9);
			Console.WriteLine("██");
			//ojos
			Console.SetCursorPosition(46, 9);
			Console.WriteLine("██");
			Console.SetCursorPosition(50, 9);
			Console.WriteLine("██");
			//alas
			Console.SetCursorPosition(66, 9);
			Console.WriteLine("██");
			
			//color NV8
			Console.ForegroundColor = ConsoleColor.White;
			Console.SetCursorPosition(42, 10);
			Console.WriteLine("████████████████████████████");
			
			//8º linea
			Console.ForegroundColor = ConsoleColor.Black;
			Console.SetCursorPosition(40, 10);
			Console.WriteLine("██");
			Console.SetCursorPosition(70, 10);
			Console.WriteLine("██");
			//alas
			Console.SetCursorPosition(66, 10);
			Console.WriteLine("██");
			
			//color NV9
			Console.ForegroundColor = ConsoleColor.White;
			Console.SetCursorPosition(42, 11);
			Console.WriteLine("██████████████████████████████");
			
			//9º linea
			Console.ForegroundColor = ConsoleColor.Black;
			Console.SetCursorPosition(40, 11);
			Console.WriteLine("██");
			Console.SetCursorPosition(72, 11);
			Console.WriteLine("██");
			//alas
			Console.SetCursorPosition(64, 11);
			Console.WriteLine("██");
			//boca
			Console.SetCursorPosition(44, 11);
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("██");
			Console.SetCursorPosition(48, 11);
			Console.WriteLine("██");
			Console.SetCursorPosition(52, 11);
			Console.WriteLine("██");
			
			//color NV10
			Console.ForegroundColor = ConsoleColor.White;
			Console.SetCursorPosition(42, 12);
			Console.WriteLine("██████████████████████████████");
			
			//10º linea
			Console.ForegroundColor = ConsoleColor.Black;
			Console.SetCursorPosition(40, 12);
			Console.WriteLine("██");
			Console.SetCursorPosition(72, 12);
			Console.WriteLine("██");
			//boca
			Console.ForegroundColor = ConsoleColor.Red;
			Console.SetCursorPosition(44, 12);
			Console.WriteLine("██");
			Console.SetCursorPosition(46, 12);
			Console.WriteLine("██");
			Console.SetCursorPosition(48, 12);
			Console.WriteLine("██");
			Console.SetCursorPosition(50, 12);
			Console.WriteLine("██");
			Console.SetCursorPosition(52, 12);
			Console.WriteLine("██");
			
			//color NV11
			Console.ForegroundColor = ConsoleColor.White;
			Console.SetCursorPosition(42, 13);
			Console.WriteLine("██████████████████████████████");
			
			//11º linea
			Console.ForegroundColor = ConsoleColor.Black;
			Console.SetCursorPosition(40, 13);
			Console.WriteLine("██");
			Console.SetCursorPosition(72, 13);
			Console.WriteLine("██");
			//boca
			Console.SetCursorPosition(44, 13);
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("██");
			Console.SetCursorPosition(46, 13);
			Console.WriteLine("██");
			Console.SetCursorPosition(48, 13);
			Console.WriteLine("██");
			Console.SetCursorPosition(50, 13);
			Console.WriteLine("██");
			Console.SetCursorPosition(52, 13);
			Console.WriteLine("██");
			
			//color NV12
			Console.ForegroundColor = ConsoleColor.White;
			Console.SetCursorPosition(42, 14);
			Console.WriteLine("██████████████████████████████");
			
			//color NV12
			Console.ForegroundColor = ConsoleColor.White;
			Console.SetCursorPosition(42, 14);
			Console.WriteLine("██████████████████████████████");
			
			//12º linea
			Console.ForegroundColor = ConsoleColor.Black;
			Console.SetCursorPosition(42, 14);
			Console.WriteLine("██");
			Console.SetCursorPosition(72, 14);
			Console.WriteLine("██");
			//boca
			Console.SetCursorPosition(46, 14);
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("██");
			Console.SetCursorPosition(48, 14);
			Console.WriteLine("██");
			Console.SetCursorPosition(50, 14);
			Console.WriteLine("██");
			Console.SetCursorPosition(52, 14);
			Console.WriteLine("██");
			Console.SetCursorPosition(54, 14);
			Console.WriteLine("██");
			
			//color NV13
			Console.ForegroundColor = ConsoleColor.White;
			Console.SetCursorPosition(42, 15);
			Console.WriteLine("██████████████████████████████");
			
			//13º linea
			Console.ForegroundColor = ConsoleColor.Black;
			Console.SetCursorPosition(42, 15);
			Console.WriteLine("██");
			Console.SetCursorPosition(70, 15);
			Console.WriteLine("██");
			//boca
			Console.SetCursorPosition(46, 15);
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("██");
			Console.SetCursorPosition(50, 15);
			Console.WriteLine("██");
			Console.SetCursorPosition(54, 15);
			Console.WriteLine("██");
			
			//color NV14
			Console.ForegroundColor = ConsoleColor.White;
			Console.SetCursorPosition(44, 16);
			Console.WriteLine("██████████████████████████");
			
			//14º linea
			Console.ForegroundColor = ConsoleColor.Black;
			Console.SetCursorPosition(44, 16);
			Console.WriteLine("██");
			Console.SetCursorPosition(68, 16);
			Console.WriteLine("██");
			
			//color NV16
			Console.ForegroundColor = ConsoleColor.White;
			Console.SetCursorPosition(46, 17);
			Console.WriteLine("██████████████████");
			
			//15º linea
			Console.ForegroundColor = ConsoleColor.Black;
			Console.SetCursorPosition(46, 17);
			Console.WriteLine("██");
			Console.SetCursorPosition(66, 17);
			Console.WriteLine("██");
			Console.SetCursorPosition(48, 17);
			Console.WriteLine("██");
			Console.SetCursorPosition(64, 17);
			Console.WriteLine("██");
			
			//16º linea
			Console.SetCursorPosition(50, 18);
			Console.WriteLine("██");
			Console.SetCursorPosition(52, 18);
			Console.WriteLine("██");
			Console.SetCursorPosition(54, 18);
			Console.WriteLine("██");
			Console.SetCursorPosition(56, 18);
			Console.WriteLine("██");
			Console.SetCursorPosition(62, 18);
			Console.WriteLine("██");
			Console.SetCursorPosition(60, 18);
			Console.WriteLine("██");
			Console.SetCursorPosition(58, 18);
			Console.WriteLine("██");
			
			//PINTURA - NV1
			Console.ForegroundColor = ConsoleColor.White;
			Console.SetCursorPosition(50, 4);
			Console.WriteLine("████████████");
			
			//NV2
			Console.SetCursorPosition(46, 5);
			Console.WriteLine("████████████████████");
			
			//NV3
			Console.SetCursorPosition(44, 6);
			Console.WriteLine("████████████████████████");
			
			//About
			Console.ForegroundColor = ConsoleColor.Black;
			Console.BackgroundColor = ConsoleColor.White;
			Console.SetCursorPosition(36, 1);
			Console.WriteLine("                                 About                                  X ");
			
			//Textos
			Console.ForegroundColor = ConsoleColor.White;
			Console.BackgroundColor = ConsoleColor.DarkGray;
			Console.SetCursorPosition(78, 5);
			Console.WriteLine("Empresa:");
			Console.SetCursorPosition(78, 6);
			Console.WriteLine("Ghostight/Tienda");
			
			Console.SetCursorPosition(78, 8);
			Console.WriteLine("Autor:");
			Console.SetCursorPosition(78, 9);
			Console.WriteLine("Juan Jimenez");
			
			Console.SetCursorPosition(78, 11);
			Console.WriteLine("Licensias:");
			Console.SetCursorPosition(78, 12);
			Console.WriteLine("XXXXXXXXX, XXXXXXX");
			
			Console.SetCursorPosition(78, 14);
			Console.WriteLine("Contacto:");
			Console.SetCursorPosition(78, 15);
			Console.WriteLine("Correo xxxxxz@gmail.com");
			Console.SetCursorPosition(78, 16);
			Console.WriteLine("Cel (+57) 301 xxx xx xx");
			
			Console.SetCursorPosition(78, 18);
			Console.WriteLine("Sede:");
			Console.SetCursorPosition(78, 19);
			Console.WriteLine("Calle xxAA #xxA - xx");
		} } }