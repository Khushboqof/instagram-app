using AutoMapper;
using Instagram.Domain.Entities;
using Instagram.Domain.Entities.Posts;
using Instagram.Domain.Entities.Users;
using Instagram.Service.DTOs.CommentDTOs;
using Instagram.Service.DTOs.LikeDTOs;
using Instagram.Service.DTOs.PostDTOs;
using Instagram.Service.DTOs.SavedPostDTOs;
using Instagram.Service.DTOs.UserDTOs;
using Instagram.Service.DTOs.UserFollowingDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instagram.Service.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserForCreationDto, User>();
            CreateMap<User, UserForViewModel>();

            CreateMap<PostForCreationDto, Post>();
            CreateMap<Post, PostForViewModel>();

            CreateMap<CommentForCreationDto, Comment>();
            CreateMap<Comment, CommentForViewModel>();

            CreateMap<LikeForCreationDto, Like>();
            CreateMap<Like, LikeForViewModel>();

            CreateMap<SavedPostForCreationDto, SavedPost>();
            CreateMap<SavedPost, SavedPostForViewModel>();

            CreateMap<UserFollowingForCreationDto, UserFollowing>();
            CreateMap<UserFollowing, UserFollowingForViewModel>();
        }
    }
}
