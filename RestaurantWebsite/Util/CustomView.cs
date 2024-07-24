using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace RestaurantWebsite.Util
{
    public class CustomView : IView 
    {
        public string Path { get; set; }

        public CustomView(string pathView) { 
           Path = pathView;
        }

        public async Task RenderAsync(ViewContext context)
        { 
          
            string content = "";

            using (StreamReader viewReader = new StreamReader(Path))
            {
                content = await viewReader.ReadToEndAsync();
            }
            await context.Writer.WriteAsync(content);
        }
    }
}
