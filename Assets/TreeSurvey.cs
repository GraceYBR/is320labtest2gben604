/*@Author: Grace Benedek Rooney
 *@UPI: gben604
 *@Subject: IS 320, Test 2
 *@Purpose: To define a TreeSurvey object
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Make sure you get rid of the namespace that is automatically generated here.
class TreeSurvey
{
    //List all the columns of your table here in the same format as below.
	public string id { get; set;}
	public string createdAt { get; set;}
	public string updatedAt { get; set; }
	public string version { get; set; }
    public string TreeID { get; set; }
    public string WhenReadingRecorded { get; set; }
    public string Location { get; set; }
    public string EcologicalValue { get; set; }
    public string HistoricalSignificance { get; set; }
    public string X { get; set; }
    public string Y { get; set; }
    public string Z { get; set; }
}
