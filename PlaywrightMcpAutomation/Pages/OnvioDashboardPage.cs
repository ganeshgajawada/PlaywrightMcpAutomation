using Microsoft.Playwright;

namespace PlaywrightMcpAutomation.Pages
{
    public class OnvioDashboardPage : BasePage
    {
        // Selectors for the tabs
        private string ClientDashboardTabSelector => "saf-tab#client-dashboard";
        private string HmrcImportsTabSelector => "saf-tab#hmrc-imports";
        private string DataEntryTabSelector => "saf-tab#data-entry";
        private string ReportsTabSelector => "saf-tab#reports";
        private string SubmissionsTabSelector => "saf-tab#submissions";

        public OnvioDashboardPage(IPage page) : base(page)
        {
        }

        public async Task NavigateToOnvioDashboard(string url)
        {
            await NavigateAsync(url);
            // Wait for the page to load completely
            await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);
        }

        public async Task ClickClientDashboardTab()
        {
            await WaitForSelectorAsync(ClientDashboardTabSelector);
            await ClickAsync(ClientDashboardTabSelector);
            await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);
        }

        public async Task ClickHmrcImportsTab()
        {
            await WaitForSelectorAsync(HmrcImportsTabSelector);
            await ClickAsync(HmrcImportsTabSelector);
            await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);
        }

        public async Task ClickDataEntryTab()
        {
            await WaitForSelectorAsync(DataEntryTabSelector);
            await ClickAsync(DataEntryTabSelector);
            await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);
        }

        public async Task ClickReportsTab()
        {
            await WaitForSelectorAsync(ReportsTabSelector);
            await ClickAsync(ReportsTabSelector);
            await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);
        }

        public async Task ClickSubmissionsTab()
        {
            await WaitForSelectorAsync(SubmissionsTabSelector);
            await ClickAsync(SubmissionsTabSelector);
            await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);
        }

        // Method to verify if a tab is visible
        public async Task<bool> IsTabVisible(string tabName)
        {
            string selector = tabName.ToLower() switch
            {
                "client dashboard" => ClientDashboardTabSelector,
                "hmrc imports" => HmrcImportsTabSelector,
                "data entry" => DataEntryTabSelector,
                "reports" => ReportsTabSelector,
                "submissions" => SubmissionsTabSelector,
                _ => throw new ArgumentException($"Unknown tab name: {tabName}")
            };

            return await IsVisibleAsync(selector);
        }
    }
}
