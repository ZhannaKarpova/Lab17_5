using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17_5
{
}
/*
done 1.1 Создать класс для моделирования счета в банке. 
done 1.2 Предусмотреть закрытые поля для номера счета, баланса, ФИО владельца.  
done 1.3 Класс должен быть объявлен как обобщенный. 
done 1.4 Универсальный параметр T должен определять тип номера счета. 
1.5 Разработать  методы  для  доступа  к  данным  –  заполнения  и  чтения. 
1.6 Создать  несколько экземпляров класса, параметризированного различными типами. 
1.7 Заполнить его поля и вывести информацию об экземпляре класса на печать.*/
public class Bank<T>
    {
        private T[] _array = Array.Empty<T>();
        private int v1;
        private int v2;
        private string v3;

        public T this[int index]
        {
            get
            {
                return _array[index];
            }
            set
            {
                _array[index] = value;
            }
        }
        
        public int Count { get { return _array.Length; } }

        public Bank(T obj, decimal balans, string name )
        {
            this.obj = obj;
            Balans = balans;
            Name= name;
        }

        public Bank(int v1, int v2, string v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        private T obj { get; set; }
        private decimal Balans { get; set; }
        private string Name { get; set; }
        public override string ToString() => $"AccountNumber - {obj}, Balans - {Balans}, Name- {Name}";

    }






