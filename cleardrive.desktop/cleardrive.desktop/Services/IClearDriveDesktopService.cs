using Models;

namespace cleardrive.desktop.Services
{
    public interface IClearDriveDesktopService
    {
        public Task<List<Position>> SelectAll();
        public Task<string> InsertAsync(Position position);
        public Task<string> DeleteAsync(Guid guid);
    }
}
