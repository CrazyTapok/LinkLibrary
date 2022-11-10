using AutoMapper;
using Data.EF;
using Data.Entities;
using Logic.DTO;
using Logic.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace Logic.Services
{
    public class LinkService : ILinkService
    {
        private readonly ApplicationContext _context;

        private readonly IMapper _mapper;

        public LinkService(ApplicationContext context, IMapper mapper)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task CreateLink(LinkDTO dto)
        {
            dto.ShortURL = GetShorLink(dto.LongURl);

            _context.Links.Add(_mapper.Map<Link>(dto));

            await _context.SaveChangesAsync();
        }

        public static string GetShorLink(string link)
        {
            string[] str = link.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);

            const string chars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            StringBuilder sb = new();
            Random rnd = new();

            for (int i = 0; i < 6; i++)
            {
                int index = rnd.Next(chars.Length);
                sb.Append(chars[index]);
            }

            return $"{str[0]}//{str[1]}/{sb}/";
        }


        public async Task DeleteLink(Guid? id)
        {
            var link = await _context.Links.FirstOrDefaultAsync(t => t.Id.Equals(id));

            if (link != null)
            {
                _context.Links.Remove(link);

                await _context.SaveChangesAsync();
            }

        }

        public async Task<IEnumerable<LinkDTO>> GetAllLinks()
        {
            return await _mapper.ProjectTo<LinkDTO>(_context.Links).ToListAsync();
        }

        public async Task<LinkDTO> GetLinkById(Guid? id)
        {
            var link = await _context.Links.FirstOrDefaultAsync(t => t.Id.Equals(id));

            return _mapper.Map<LinkDTO>(link);
        }

        public async Task UpdateLink(LinkDTO dto)
        {
            var link = await _context.Links.FirstOrDefaultAsync(t => t.Id.Equals(dto.Id));

            if (link != null)
            {
                link.LongURl = dto.LongURl;
                link.ShortURL = GetShorLink(dto.LongURl);

                _context.Links.Update(link);

                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateVisitsNumber(Guid? id)
        {
            var link = await _context.Links.FirstOrDefaultAsync(t => t.Id.Equals(id));

            if (link != null)
            {
                link.VisitsNumber += 1;

                _context.Links.Update(link);

                await _context.SaveChangesAsync();
            }
        }
    }
}
