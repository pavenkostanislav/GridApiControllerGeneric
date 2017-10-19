﻿using TEST.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TEST.Models
{
    [Table("Chat", Schema = "dbo")]
    public class Chat : IIdModel, IDisplayName, IClearVirtualPropertiesModel
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        ///  writer
        /// </summary>
        public int AuthorId { get; set; }

        /// <summary>
        ///  Message
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        ///  likes count
        /// </summary>
        public int? Rating { get; set; }

        /// <summary>
        ///  likes users
        /// </summary>
        public string RatedUsers { get; set; }

        /// <summary>
        ///  Owner company
        /// </summary>
        public int OwnerId { get; set; }

        public string DisplayName { get; set; }

        [StringLength(100)]
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        [StringLength(100)]
        public string LastUpdatedBy { get; set; }
        public DateTime LastUpdatedDate { get; set; }

        public void ClearVirtualProperties()
        {

        }
    }
    public class ChatViewModel : Chat
    {
        public ChatViewModel() { }
        public ChatViewModel(Chat Companent)
        {
            if (Companent != null)
            {
                //this.AttachmentCount = new string(Companent.Author?.DisplayName?.ToArray());
                //this.AuthorName = new string(Companent.Author?.DisplayName?.ToArray());
                //this.EmployeeId = employeeManager.GetEmployeeModelByUser(m.AuthorId)?.Id;
                //this.EmployeePhotoFileName = employeeManager.GetEmployeeModelByUser(m.AuthorId)?.PhotoFileName;
            }
        }
        public int? TableId { get; set; }
        public int? AttachmentCount { get; set; }
        public string AuthorName { get; set; }
        public int? EmployeeId { get; set; }
        public string EmployeePhotoFileName { get; set; }
        public string PhotoSrc { get; set; }
    }
    public class ChatFindModel : Chat
    {
    }
}
