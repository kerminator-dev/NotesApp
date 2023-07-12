using AutoMapper;
using NotesApp.Extensions;
using NotesApp.Models;
using NotesApp.ViewModels;

namespace NotesApp.Mappings
{
    public class MappingProfile : Profile
    {
        private const int SHORT_TITLE_LENGTH = 47;
        private const int SHORT_CONTENT_LENGTH = 87;
        private const string END_STRING = "...";

        public MappingProfile()
        {
            CreateMap<Note, NoteViewModel>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.ShortTitle, opt => opt.MapFrom(src => src.Title.Substring(SHORT_TITLE_LENGTH, END_STRING)))
                .ForMember(dest => dest.ShortContent, opt => opt.MapFrom(src => src.Content.Substring(SHORT_CONTENT_LENGTH, END_STRING)))
                .ForMember(dest => dest.ShortCreated, opt => opt.MapFrom(src => src.Created.ToShortDateTimeString()));
        }
    }
}
