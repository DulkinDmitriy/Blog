﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.WebUI.TransferModels.CommentModels
{
    public class CreateCommentTransferModel
    {
        public string Content { get; set; }
        public string AuthorId { get; set; }
        public string PostId { get; set; }
    }
}
