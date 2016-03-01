def sort(list_):#gert er rad fyrir ad lengd innntaks se 2
	if list_[0] >= list_[1]:
		pass
	else:
		x = list_[0]
		list_[0] = list_[1]
		list_[1] = x
	return list_

def merge(list_1, list_2):
	new = []
	sorte = False
	list_1_counter = 0
	list_2_counter = 0
	while sorte == False:
		if list_1[list_1_counter] <= list_2[list_2_counter]:
			new.append(list_1[list_1_counter])
			list_2_counter = list_2_counter + 1
		else:
			new.append(list_2[list_2_counter])
			list_1_counter = list_1_counter + 1
		if list_1_counter == 1 && list_2_counter == 1:
			sorte = True
	return new

org_list = [3,5,2,6,4,7,8,1]#Gert er rad fyrir ad listin se 8

level_1_1 = []
level_1_2 = []

org_len = len(org_list)

for x in xrange(1,(org_len/2):
	level_1_1.append(org_list[x])

for x in xrange((org_len/2),org_len):
	level_1_2.append(org_list[x])

new_len = org_len/2

level_2_1 = []
level_2_2 = []
level_2_3 = []
level_2_4 = []

for x in xrange(1,new_len/2):
	level_2_1.append(level_1_1[x])
	level_2_3.append(level_1_2[x])

for x in xrange(new_len/2,new_len):
	level_2_2.append(level_1_1[x])
	level_2_4.append(level_1_2[x])

level_2_1 = sort(level_2_1)
level_2_2 = sort(level_2_2)
level_2_3 = sort(level_2_3)
level_2_4 = sort(level_2_4)

level_1_1 = merge(level_2_1, level_2_2)
level_1_2 = merge(level_2_3, level_2_4)

org_list = merge(level_1_1, level_1_2)

print(org_list)