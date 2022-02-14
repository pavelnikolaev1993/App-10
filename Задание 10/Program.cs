/*1.Угол задан с помощью целочисленных значений gradus - градусов, min - угловых минут, sec - угловых секунд. 
 * Реализовать класс, в котором указанные значения представлены в виде свойств. Для свойств предусмотреть проверку корректности данных. 
 * Класс должен содержать конструктор для установки начальных значений, а также метод ToRadians для перевода угла в радианы. 
 * Создать объект на основе разработанного класса. Осуществить использование объекта в программе.*/
Corner c = new Corner();
c.ToRadians();
class Corner
{
    public double gradus;
    public double Gradus
    {
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Выражение должно быть больше ноля");
            }
            else
            {
                gradus = value;
                
            }
        }
        get
        {
            return gradus;
        }
    }
    public double min;
    public double Min
    {
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Выражение должно быть больше ноля");
            }
            else
            {
                min = value;

            }
        }
        get
        {
            return min;
        }
    }
    public double sec;
    public double Sec
    {
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Выражение должно быть больше ноля");
            }
            else
            {
                sec = value;

            }
        }
        get
        {
            return sec;
        }
    }
    public double rad;
 public Corner()
    {

        Console.WriteLine("Введите величину угла в градусах");
        Gradus = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите величину угла в минутах");
        Min = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите величину угла в секундах");
        Sec = Convert.ToInt32(Console.ReadLine());
      
    }
 public void ToRadians()
    {
        rad = (gradus * (3.1415926535 / 180)) + (min * (3.1415926535 / (180 * 60))) + (sec * (3.1415926535 / (180 * 60 * 60)));
        Console.WriteLine($"Значения угла: {gradus} градусов, {min} минут, {sec} секунд. Величина угла в радиане: {rad}");
    }
}
    
    
 