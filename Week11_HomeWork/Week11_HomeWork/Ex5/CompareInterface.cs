namespace Week11_HomeWork.Ex5
{
    //Create a generic interface that defines a method for comparing two items of the same type.
    //Implement this interface in a class that compares two items based on their
    //length (for strings) or size (for collections).
    interface CompareInterface <T>
    {
        T Compare<T>(T firstValue, T secondValue);

        //ICollection<U> Compare2<U>(ICollection<U> firstValue, ICollection<U> secondValue);
    }
}
