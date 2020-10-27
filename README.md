# **Californians on the Move**

## **Project Description and Scope**

More Californians are leaving the state than migrating into the state. 

Following these data points, we set out to prove this statement:

* increased poverty levels
* increased population 
* Transportation/traffic congestion (time to/from work)
* unemployment rates
* reduced incomes (per capita income levels)
* higher income inequality
* higher housing costs 
* higher taxes 

Population Scope Baseline: California

Population Competitive View: Colorado, Florida, Idaho, Oregon, Texas

5 states chosen based on migration data and supporting articles of top states Californians moving to
Time Frame: 5 year time frame 2013-2018

## **Team and Contributions**

* **Jenifer Hwang**: Project manager, Results discussion, Mining data and script/analysis for Population, Migration and Poverty.

* **Daniel Kim**: Mining data and script/analysis Mining data for Unemployment, Demographics (i.e., race).

* **Natalia Karimova**: Results discussion, ReadMe.md file, Script for collecting data from Census into one DataFrame (jupyter notbook script), VBA script to pull migration data together from Census Excel files, put all analysis-scripts together in one final script, Mining data and script/analysis for Rent and Housing.

* **Hossein Esteaneh**: Results discussion, Mining data and script/analysis for Transportation/Traffic Congestion.

* **Sara McLean**: Results discussion, Generating the Proposal and Final PowerPoint Presentation, Mining data and script/analysis for Household Income, Gini Co-efficient.

## **Data Set and Supporting Information**

* Transportation; Population; Incomes; Housing Costs; Taxation; Populations

    * api.census.gov/

* State-to-state migration Tables (Census): 

    * https://www.census.gov/data/tables/time-series/demo/geographic-mobility/state-to-state-migration.html

* Supporting Information:

    * https://www.economy.com/united-states/net-migration

    * https://www.nytimes.com/2020/01/09/upshot/american-population-slowdown.html

    * https://www.prb.org/usdata/indicator/migration/map/state/2010/ 

    * https://www.census.gov/library/stories/2019/04/moves-from-south-west-dominate-recent-migration-flows.html

    * https://www.ocregister.com/2019/10/31/190122-more-people-left-california-last-year-vs-arrived-a-38-jump/

    * https://showmehome.com/unpacking-californias-migration-trends/ 

    * https://www.ppic.org/press-release/whos-movin-out-of-california/ 	

    * https://www.latimes.com/california/story/2019-12-21/california-population-continues-to-decline-with-state-emigration-a-major-factor

    * https://next10.org/sites/default/files/California-Migration-Final2.pdf


Generated data files:

* Total_Migration_2013-2018_CSV.csv - migration data for all states (number people move_in, number people move_out, delta = (number people move_in) - (number people move_out)
   * `move_in` - number people moved into the specific state this year
   * `move_out` - number people moved out from the specific state this year
   * `Delta` = (`move_in` - `move_out`). For excample, CA has negative delta that means that more people move out of this state that moved in. Population of state with negative value is decreasing.

* all_census_data.csv - final DataFrame used for analysis for CA, FL, OR, CO, ID, TX (2013-2018 years):
   * `Population` - 
   * `Per Capita Income` - 
   * `Poverty Count` - 
   * `Rent(%)` -  Median Rent as a Percentage of Houshold Income
   * `House with mortgage(%)` -  Median Owner Cost for House WITH Mortgage as a Percentage of Houshold Income 
   * `House without mortgage(%)` -  Median Owner Cost for House WITHOUT Mortgage as a Percentage of Houshold Income 
   * `Mean of Trans by Age` - 
   * `Travel Time to Work` - 
   * `Race Total` - 
   * `White alone` - 
   * `Block or African American alone` - 
   * `American Indian and Alaska Native Alone` - 
   * `Asian Alone` - 
   * `Unemployement count` - 





