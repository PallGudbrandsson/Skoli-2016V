input_list = [1,5,3,2,35,5,6,2,3,4,6,3,65,4,3,78,6,7,8,7,5]
output_list = [] 

top = max(input_list)

for x in xrange(1,len(input_list)):
	if input_list[x] == top:
		output_list.append(x)

print "Haedsta gildid var " + str(top)

if len(output_list) == 1:
	print "Thad kom fyrir einu sinnu med visinn " + str(output_list[0])
else:
	print "Thad kom fyrir " + str(len(output_list)) + " sinnum"
	print "Med visana"
	for x in xrange(0,len(output_list)):
	 	print str(output_list[x])
