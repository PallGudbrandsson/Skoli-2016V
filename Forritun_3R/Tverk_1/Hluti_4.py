input_list = [1,5,3,2,35,5,6,2,3,4,6,3,65,4,3,78,6,7,8,7]
top = max(input_list)
number = []

for x in xrange(1,len(input_list)):
	if input_list[x] != top:
		number.append(input_list[x])

top = max(number)

number = []

for x in xrange(1,len(input_list)):
	if input_list[x] == top:
		number.append(x)

print "Naest haedsta gildid var " + str(top)

if len(number) == 1:
	print "Thad kom fyrir einu sinnu med visinn " + str(number[0])
else:
	print "Thad kom fyrir " + str(len(number)) + " sinnum"
	print "Med visana"
	for x in xrange(0,len(number)):
	 	print str(number[x])