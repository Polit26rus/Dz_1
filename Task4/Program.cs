Console.WriteLine("Введите 3 числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int ma = a;

if(a == b && b == c){
    Console.WriteLine("Максимума нет");
}

else
    {
        if(a >= b){
        ma = a;
        }
        else {
            ma = b;
        }
    if(ma > c){
        ma = ma;
    }
    else if(ma < c){
        ma = c;
    }
    else { ma = ma; }

    Console.WriteLine("Максимум равен: " + ma);
    
    }