using Logic.DTO;

namespace Logic.Interfaces
{
    public interface ILinkService
    {
        Task<IEnumerable<LinkDTO>> GetAllLinks();
        Task<LinkDTO> GetLinkById(Guid? id);
        Task CreateLink(LinkDTO dto);
        Task UpdateLink(LinkDTO dto);
        Task DeleteLink(Guid? id);
        Task UpdateVisitsNumber(Guid? id);
    }
}
