﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskBoardApp.Data;
using TaskBoardApp.Models.Board;
using TaskBoardApp.Models.Task;
namespace TaskBoardApp.Controllers
{
    public class BoardController : Controller
    {
        private readonly TaskBoardAppDbContext _data;
        public BoardController(TaskBoardAppDbContext context)
        {
            _data = context;
        }
        public async Task<IActionResult> All()
        {
            var boards=  await _data
                .Boards
                .Select(b=>new BoardViewModel()
                {
                    Id = b.Id,
                    Name = b.Name,
                    Tasks=b
                    .Tasks
                    .Select(t=>new TaskViewModel()
                    {
                        Id=t.Id,
                        Title = t.Title,
                        Description = t.Description,
                        Owner=t.Owner.UserName
                    })
                })
                .ToListAsync();

            return View(boards);
        }
    }
}
