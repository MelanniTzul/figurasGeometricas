/*Realizar con la menor cantidad de código posible las figuras geométricas.
Mínimo 7 figuras geométricas.
Seleccionando la figura a mostrar mediante un menú.*/

Console.SetWindowSize(100, 40);//ESTABLECER TAMAÑO DE PANTALLA

int numero;//Opcion del menu
do
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("FIGURAS GEOMETRICAS");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("1. CUADRADO");
    Console.WriteLine("2. TRIANGULO");
    Console.WriteLine("3. RECTANGULO");
    Console.WriteLine("4. ROMBO");
    Console.WriteLine("5. CIRCULO");
    Console.WriteLine("6. TRAPECIO");
    Console.WriteLine("7. ROMBOIDE");
    Console.WriteLine("8. SALIR \n");
    Console.WriteLine("Ingrese la opcion que desea: ");
    numero = Convert.ToInt32(Console.ReadLine());
    Console.Clear();//Limpiar pantalla
    Console.WriteLine("\n");

    //Entra a las opciones
    if (numero == 1)//Cuadrado
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine( "                  CUADRADO                " );
       
        for (int i = 0; i < 20; i++) ////FIGURA GEOMETRICA CUADRADO-CICLO FOR O REPETIR CODIGO
        {

            //lado de arriba horizontal
            Console.ForegroundColor = ConsoleColor.Cyan;          
            Console.SetCursorPosition(10 + i, 3);//POSICION EN PANTALLA
            Console.WriteLine("*");           
            Thread.Sleep(1);//ESTO ES UNA PAUSA DE 1SEG

            //Lado de abajo horizontal 
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(10 + i, 12);
            Console.WriteLine("*");        
            Thread.Sleep(1);   //ESTO ES UNA PAUSA DE 1SEG

        }

        for (int i = 0; i < 10; i++)
        {
            //Lado izquierdo vertical 
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(10, 3 + i);
            Console.WriteLine("*");
            
            Thread.Sleep(1);//ESTO ES UNA PAUSA DE 1SEG

            //Lado derecho vertical 
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(30, 3 + i);
            Console.WriteLine("*");          
            Thread.Sleep(1);//ESTO ES UNA PAUSA DE 1SEG
        }

    }
    else if (numero == 2)//Triangulo
    {

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("                  TRIANGULO                ");
        
        
        for (int x = 0; x <15; x++)//FIGURA GEOMETRICA TRIANGULO
        {
            //Lado izquierdo 
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(6+x, 20 - x);
            Console.WriteLine("*");
            Thread.Sleep(1);//ESTO ES UNA PAUSA DE 1SEG

            //Lado derecho
            Console.SetCursorPosition(20+x, x +6);
            Console.WriteLine("*");
            Thread.Sleep(1);//ESTO ES UNA PAUSA DE 1SEG

        }
        //Lado de abajo
         for(int i=0; i<28; i++)
        {
            Console.SetCursorPosition(6 + i, 20);
            Console.WriteLine("*");
            Thread.Sleep(1);
        }
    }
    else if (numero==3)//Rectangulo
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("                  RECTANGULO                ");
        for(int i=0; i<30; i++)
        {
            //Lado de arriba horizontal
            Console.ForegroundColor = ConsoleColor.Green;          
            Console.SetCursorPosition(10 + i, 3);//POSICION EN PANTALLA
            Console.WriteLine("*");          
            Thread.Sleep(1);//ESTO ES UNA PAUSA DE 1SEG

            //Lado de abajo horizontal 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(10 + i, 12);
            Console.WriteLine("*");          
            Thread.Sleep(1);//ESTO ES UNA PAUSA DE 1SEG
        }

        for(int i=0; i<10; i++)
        {
            //Lado izquierdo vertical 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(10, 3 + i);
            Console.WriteLine("*");            
            Thread.Sleep(1);//ESTO ES UNA PAUSA DE 1SEG

            //Lado derecho vertical 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(40, 3 + i);
            Console.WriteLine("*");          
            Thread.Sleep(1);//ESTO ES UNA PAUSA DE 1SEG
        }    
    }
    else if (numero==4)//Rombo
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("                       ROMBO                ");
        for(int i=0; i<6; i++)
        {
            //Lado derecho de abajo
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(30 - i, 10 + i);
            Console.WriteLine("*");
            Thread.Sleep(2);//ESTO ES UNA PAUSA DE 1SEG

            //Lado derecho de arriba
            Console.SetCursorPosition( 30-i,10 - i);           
            Console.WriteLine("*");
            Thread.Sleep(2);//ESTO ES UNA PAUSA DE 1SEG

            //Lado izquierdo de arriba
            Console.SetCursorPosition(20 + i, 10 - i);
            Console.WriteLine("*");
            Thread.Sleep(2);//ESTO ES UNA PAUSA DE 1SEG

            Console.SetCursorPosition(20 + i, 10 + i);
            Console.WriteLine("*");
            Thread.Sleep(2);//ESTO ES UNA PAUSA DE 1SEG
        }
    }

    else if (numero==5)//Circulo
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("    CIRCULO   \n\n");
        Console.ForegroundColor = ConsoleColor.Green;
     
        //Clase Math sirve para trabajar con potencias
        for (int i = 0; i <= 8 * 2; i++)//Altura
        {
            for (int j = 0; j <= 8 * 2; j++)//Rellenar
            {
                //Ecuacion circunferencia
               // Dato en x, dato en y, h y k son origen y r= radio 
                //((x-h^2)+(y-k)^2)=radio^2
                if (Math.Pow(j - 8, 2) + Math.Pow(i - 8, 2) <= (int)Math.Pow(8, 2))
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine(" ");
        }

    }
    else if (numero==6)//TRAPECIO
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("                  TRAPECIO                ");
       
        //Lado de arriba
        for (int i=0; i<21; i++) {
             
            Console.ForegroundColor = ConsoleColor.Cyan;
            //POSICION EN PANTALLA
            Console.SetCursorPosition(17 + i, 7);
            Console.WriteLine("*");
            //ESTO ES UNA PAUSA DE 1SEG
            Thread.Sleep(1);
        }

        //Lado de abajo
        for (int i = 0; i < 35; i++)
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            //POSICION EN PANTALLA
            Console.SetCursorPosition(10 + i, 15);
            Console.WriteLine("*");
            //ESTO ES UNA PAUSA DE 1SEG
            Thread.Sleep(1);
        }


        for (int i = 0; i < 9; i++)
        {
            
           // Izquierda
            Console.SetCursorPosition(9 + i, 15 - i);
            Console.WriteLine("*");
            Thread.Sleep(2);//ESTO ES UNA PAUSA DE 1SEG

            //Derecha
            Console.SetCursorPosition(37+ i, i+7);
            Console.WriteLine("*");
            Thread.Sleep(2);//ESTO ES UNA PAUSA DE 1SEG        
        }
    }
    else if(numero==7)//ROMBOIDE
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("                                ROMBOIDE                ");
     
        for (int i = 0; i < 35; i++)  //Lado de arriba
        {
            Console.ForegroundColor = ConsoleColor.Magenta;            
            Console.SetCursorPosition(17 + i, 7);//POSICION EN PANTALLA
            Console.WriteLine("*");          
            Thread.Sleep(1); //ESTO ES UNA PAUSA DE 1SEG
        }
      
        for (int i = 0; i < 34; i++) //Lado de abajo
        {
            
            Console.SetCursorPosition(10 + i, 15);//POSICION EN PANTALLA
            Console.WriteLine("*");          
            Thread.Sleep(1);//ESTO ES UNA PAUSA DE 1SEG
        }

        for (int i = 0; i < 9; i++)
        {
            // Izquierda
            Console.SetCursorPosition(9 + i, 15 - i);
            Console.WriteLine("*");
            Thread.Sleep(2);//ESTO ES UNA PAUSA DE 1SEG

            //Derecha
            Console.SetCursorPosition(51 - i, i + 7);
            Console.WriteLine("*");
            Thread.Sleep(2);//ESTO ES UNA PAUSA DE 1SEG

        }

    }
    else if(numero==8)
    {
        Console.ForegroundColor= ConsoleColor.DarkGreen;//Color letras
        Console.WriteLine("¡EL programa a finalizado!");
        Environment.Exit(0);//Finalizar el programa

    }

    Console.WriteLine("\n");
    Console.ForegroundColor = ConsoleColor.White;

} while(numero != 100);
