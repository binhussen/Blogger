﻿using Blogger.Application.Comments.GetReplaies;
using Blogger.Domain.ArticleAggregate;
using Blogger.Domain.CommentAggregate;

namespace Blogger.APIs.Endpoints.Comments.GetReplaies;

public class GetReplaiesMappingProfile : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.ForType<GetReplaiesRequest, GetReplaiesQuery>()
                   .Map(x => x.CommentId, src => CommentId.Create(src.CommentId));

        config.ForType<GetReplaiesResponse, GetReplaiesQueryResponse>();
    }
}