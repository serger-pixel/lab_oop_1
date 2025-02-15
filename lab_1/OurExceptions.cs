using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace lab_1
{
    public static class Regs 
    {
        public const String _nameReg = "^[A-Z][A-Za-z]{0,19}$";
        public const String _priceReg = "^(100(,0+)?|[1-9]\\d{2,4}(,\\d+)?|100000(,0+)?)$";
        public const String _cntUsersReg = "^(100|[1-9]?[0-9])$";
        public const int maxSpeed = 6144;
        public const int minSpeed = 1;
        public const int zeroUsers = 0;
    }

    public static class ExceptionMessages 
    {
        public const String NAMEEXCEP = "Имя опрератора должно" +
          " начинаться с заглавной буквы на латинице и должно содержать " +
          "не более 20 символов";

        public const String PRICEEXCEP = "Минимальная цена - 100 денежных ед., " +
            "максимальный - 100000 денежных ед.";

        public const String CNTUSERSEXCEP = "Не более 100 пользователей, " +
            "значение должно быть натуральным числом";

        public const String SPEEDEXCEP = "Не более 6144 мб в секунду, " +
            "значение должно быть натуральным числом";

        public const String DIVBYZEROEXCEP = "Колличество пользователей должно быть больше 0";

        public const String OBJECTEXISTS = "Объект с таким именем уже существует";

        public const String OBJWASNTCHOSEN = "Объект не выбран";

        public const String FILEDNOTCHOSEN = "Поле не выбрано";
    }

    public class NameException : Exception
    {
        public NameException() : base(ExceptionMessages.NAMEEXCEP) { }
    }

    public class PriceException : Exception
    {
       public PriceException() : base(ExceptionMessages.PRICEEXCEP) { }
    }

    public class CntUsersException : Exception
    {
        public CntUsersException() : base(ExceptionMessages.CNTUSERSEXCEP) { }
    }

    public class SpeedException : Exception
    {
        public SpeedException() : base(ExceptionMessages.SPEEDEXCEP) { }
    }

    public class CntZeroUsers : DivideByZeroException
    {
        public CntZeroUsers() : base(ExceptionMessages.DIVBYZEROEXCEP) { }
    }

    public class ObjectExists : Exception
    {
        public ObjectExists() : base(ExceptionMessages.OBJECTEXISTS) { }
    }

    public class ObjWasntChosen : Exception 
    {
        public ObjWasntChosen() : base(ExceptionMessages.OBJWASNTCHOSEN) { }
    }

    public class FieldNotChosen : Exception 
    {
        public FieldNotChosen() : base(ExceptionMessages.FILEDNOTCHOSEN) { }
    }
}
