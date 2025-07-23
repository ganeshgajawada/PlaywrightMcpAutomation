# PlaywrightMcpAutomation

This project demonstrates how to use the Playwright MCP server to automate web testing scenarios. It includes a Page Object Model (POM) implementation for better maintainability and organization of test code.

## Project Structure

- `Pages/`: Contains Page Object Model classes
  - `BasePage.cs`: Base class with common methods for all pages
  - `OnvioDashboardPage.cs`: Page object for the Onvio dashboard with tab navigation methods
- `OnvioTabsTest.cs`: Test class demonstrating how to use the MCP Playwright server

## Scenario Automated

The project automates the following scenario:

1. Launch URL: https://demo.onvio.co.uk/uktaxembedded/clients/9c5adc87089540758e56b32300651b9b/taxyear/2026/data-entry?udslongtoken=17EE0A22845844CA9BC89B92AE12A84F
2. Click on client dashboard, HMRC imports, data entry, reports, and submissions tabs

## Using MCP Playwright Server

The MCP Playwright server provides tools to automate browser interactions. Here's how to use it:

```csharp
// Launch the browser and navigate to a URL
await use_mcp_tool("github.com/executeautomation/mcp-playwright", "playwright_navigate", {
  "url": "https://demo.onvio.co.uk/uktaxembedded/clients/9c5adc87089540758e56b32300651b9b/taxyear/2026/data-entry?udslongtoken=17EE0A22845844CA9BC89B92AE12A84F",
  "browserType": "chromium",
  "headless": false,
  "width": 1280,
  "height": 720
});

// Click on elements
await use_mcp_tool("github.com/executeautomation/mcp-playwright", "playwright_click", {
  "selector": "saf-tab#client-dashboard"
});

// Take screenshots
await use_mcp_tool("github.com/executeautomation/mcp-playwright", "playwright_screenshot", {
  "name": "onvio_dashboard",
  "fullPage": true,
  "storeBase64": true
});

// Close the browser
await use_mcp_tool("github.com/executeautomation/mcp-playwright", "playwright_close", {});
```

## Running the Tests

To run the tests, you need to have the .NET SDK installed. Then you can run the tests using the following command:

```bash
dotnet test
```

Note: The actual test implementation uses the MCP Playwright server directly, not through the MSTest framework.
