Console.WriteLine("Введите 2 числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if(a > b){
    Console.WriteLine("Максимум равен:" + a);
}
else if(b > a){
    Console.WriteLine("Максимум равен:" + b);
}
else {
    Console.WriteLine("Максимума нет");
}