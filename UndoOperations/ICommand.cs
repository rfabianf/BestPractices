namespace UndoOperations
{
    public interface ICommand
    {
        void Call();
        void Undo();
    }
}