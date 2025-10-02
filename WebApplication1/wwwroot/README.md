# MIS 421/521 Assignment 2: Azure AI Search

Create an Azure AI Search service with sample data from the real estate database. See class video from lecture.

>Use the provided index.html file to:
- Change ALL JS and CSS file references to have SRI hashes. [Srihash](srihash.org) is an excellent tool for this.
- In Azure, create a new 'AI Search' service with the following aspects:
	- On the Overview page of the service, note the URL.
	- Resource Group: Whatever you want to name it. 'RealEstateSearch' is a good option.
	- For 'Service name', it MUST be lowercase with only letters and numbers. Here is a good format: lastname + sp25 + mis521. So for me: hudnallsp25mis521
	- Click 'Change Pricing Tier' and select the FREE SKU. THIS IS VERY IMPORTANT!!!!!!!!!!!!!!!!!!!!!
	- Click 'Review and create'
	- Once the service is created, on the 'Overview' pane, under "Connect your data", click import. From the dropdown, select 'Samples'. Choose 'realestate-us-sample'. Click the next button at the bottom. Click 'Skip to: Customize target index'. Write down the name of the index. Click 'Next: Create an indexer'. Click Submit.
	- From the service home page, click 'Settings' on the left and click 'Keys'. Click 'Manage query keys' and copy the query key that is there.
	

- HTML:
  - [ ] A new title for the site that is not 'Azure AI Search' (be creative).
  - [ ] A title of the same name (browser tab title).
  - [ ] A second button that will display the current time.
  - [ ] A second empty div with an ID of 'time'.
- CSS:
  - [ ] Set the background of the 'facetPanel' div to an image of your choice. ([Unsplash](unsplash.com) is a great resource for free images)
  - [ ] Style the rest of the page however you see fit. Points will be lost if little or no effort is given in styling your site.
- JS:
  - [ ] Replace YOUR_SERVICE_NAME, YOUR_INDEX_NAME, and YOUR_QUERY_API_KEY with what you get from Azure.
  - [ ] Write a function that changes the background image of your site on a click of your search engine name. You can cycle through a set of pre-defined images or randomly select one.
  - [ ] Write a function that gets the current time (formatted HH:MM), loads the result into your 'time' div, and displays the div as a JQuery UI dialog window on a click of your time button.
- BONUS:
  - [ ] Implement a 'I'm feeling lucky' button. This button should randomly select only ONE home from the applicable results and display that one home in the results area.
  - [ ] Modify the function that changes your background image so that each click cycles through different images without refreshing the page.
- Deploy your site to Azure, following the instructions provided on Blackboard.

> It is best to take this little pieces at a time, step by step, as not to get confused by too many things at once. W3 Schools is an amazing resource, and has examples on everything above if you get stuck.
