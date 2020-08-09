using System;
using System.Collections.Generic;
using System.Text;

namespace TodoApp.Models
{
    public interface ITodoRepository
    {
        void Add(Todo model);   // 입력
        List<Todo> GetAll();    // 출력
    }
}
