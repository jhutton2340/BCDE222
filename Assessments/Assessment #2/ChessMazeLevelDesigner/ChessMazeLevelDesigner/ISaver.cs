namespace ChessMazeLevelDesigner
{
    public interface ISaver
    {
        void Save(string filename, IFileable callMeBackforDetails);
    }
}
