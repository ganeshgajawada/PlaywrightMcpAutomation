using Microsoft.Playwright;

namespace PlaywrightMcpAutomation.Pages
{
    public class BasePage
    {
        protected readonly IPage Page;

        public BasePage(IPage page)
        {
            Page = page;
        }

        public async Task NavigateAsync(string url)
        {
            await Page.GotoAsync(url);
        }

        public async Task ClickAsync(string selector)
        {
            await Page.ClickAsync(selector);
        }

        public async Task FillAsync(string selector, string value)
        {
            await Page.FillAsync(selector, value);
        }

        public async Task<bool> IsVisibleAsync(string selector)
        {
            return await Page.IsVisibleAsync(selector);
        }

        public async Task WaitForSelectorAsync(string selector)
        {
            await Page.WaitForSelectorAsync(selector);
        }
    }
}
