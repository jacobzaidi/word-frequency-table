/**

	Takes a file and creates a word frequency table.
	
	Name: Saqib Zaidi Sahib
	
	UPI: ssah933
	
	AUID: 222479856
	
	COMPSCI 335 S2 2018 Assignment 1

*/

try {
    var args = process.argv.slice(2);
    var k = 3
    var path = args[0]
    if (args.length == 2) 
        k = args[1]
    var contents = require("fs")
        .readFileSync(path, { "encoding": "utf8" })
        .replace(/[^A-Za-z]|\s+/g, " ").trim().replace(/\s+/g, " ").split(' ')
    var Enumerable = require("linq-es2015")
    let aList = Enumerable.asEnumerable(contents)
        .GroupBy(s => s.toUpperCase())
        .Select(g => [g.length, g.key])
        .OrderByDescending(kc => kc[0])
        .ThenBy(kc => kc[1])
        .toArray()
        .slice(0, k)
    aList.forEach(kc => console.log(kc[0] + " " + kc[1] + "\n"))
    0
}
catch (error) {
    console.log("***Error: %s", error.message)
	0
}