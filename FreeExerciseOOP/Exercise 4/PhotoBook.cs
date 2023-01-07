namespace FreeExerciseOOP.Exercise4
{
    public class PhotoBook
    {
    protected int _numPages;
    public int GetNumberPages()
        {
            return _numPages;
        }
    public PhotoBook()
        {
            _numPages = 16;
        }
    public PhotoBook(int numPages)
        {
            _numPages= numPages;
        }
    }
}
