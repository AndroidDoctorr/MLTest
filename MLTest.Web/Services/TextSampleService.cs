using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MLTest.Data;
using MLTest.Models;
using System.Linq;
using System.Threading.Tasks;
using PagedList;
using System;

namespace MLTest.Services
{
    public class TextSampleService
    {
        private AppDbContext _db;

        public TextSampleService(AppDbContext db)
        {
            _db = db;
        }

        public bool CreateTextSample(TextSampleCreate model)
        {
            var newSample = new TextSample()
            {
                Text = model.Text,
                Lang = model.Lang
            };

            _db.TextSamples.Add(newSample);

            return _db.SaveChanges() == 1;
        }

        public async Task<IPagedList<TextSampleListItem>> GetSamplesAsync(int page)
        {
            var samples = await _db.TextSamples.Select(s => new TextSampleListItem()
            {
                Lang = s.Lang,
                Text = s.Text,
                Id = s.Id,
            }).OrderBy(s => s.Lang).ToListAsync();

            return samples.ToPagedList(page, 20);
        }

        public async Task<bool> EditSampleAsync(int id, TextSampleListItem sample)
        {
            Console.WriteLine("Edit Sample: " + id + ": " + sample.Text);
            var oldSample = await _db.TextSamples.FindAsync(id);
            oldSample.Text = sample.Text;
            return (await _db.SaveChangesAsync() == 1);
        }
    }
}