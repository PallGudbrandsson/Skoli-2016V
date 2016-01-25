input_list = [1, 2, 3, 4]
list.sort(input_list)
half = len(input_list) / 2

print str(len(input_list))

if half % 2 == 0:
	half = half -1
	print "Midgildid er " + str(((input_list[half]+input_list[half+1])/2))
else:
	print "Midgildid er " + str(input_list[half])