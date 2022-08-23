// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
/*

        int Find2ndDigit(){
            int num = new Random().Next(100, 1000);
            Console.WriteLine("Ваше число сегодня: " + num);
            int xy = num % 100;
            int x = xy / 10;
            return x;
            }
        Console.WriteLine("Вторая цифра в Вашем числе: " + Find2ndDigit());              
    
*/


// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

/*

        void Find2ndDigit(){
            int num = new Random().Next(100, 1000);
            Console.WriteLine("Ваше число сегодня: " + num);
            int xy = num % 100;
            int x = xy / 10;
            Console.WriteLine("Вторая цифра в Вашем числе: " + x);
            }
        Find2ndDigit();

*/


//Задача 13: Напишите программу, которая выводит третью цифру заданного 
//числа или сообщает, что третьей цифры нет.

/*

         void find3ddigit(int num){
              if (num > 999 || num > 99){
              while (num > 999){
                     num = num / 10;}
                     num = num % 10;
                     Console.WriteLine("Третья цифра Вашего числа: " + num);
               }                  
                        
                else {
                    Console.WriteLine("Число отрицательное или слишком короткое!");}
         }   
            
            Console.WriteLine("Введите число, что бы узнать какая цифра третья: ");
            int num = Convert.ToInt32(Console.ReadLine());
            find3ddigit(num);

*/


// Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

/*

    void w_day(int num){
        if (num >= 1 && num <= 5)
                Console.WriteLine("К сожалению рабочий день, придется поработать! :(");
        else if (num >= 6 && num <= 7)
                Console.WriteLine("Ура! Это будет Выходной! =)");
        else
                Console.WriteLine("Это не похоже на день недели! Попробуй ещё раз!");
        }                  
                        
        Console.WriteLine("Введите цифру дня недели: ");
        int num = Convert.ToInt32(Console.ReadLine());
        w_day(num);

*/
               