##  The two tenets of coding are:
##  1: "Esoteric languages are a joke thing. No one should ever use them"
##  2: "Solving code challenges using excel spreadsheets counts as an esoteric language"
##--------------------------------------------------------------------------------------
# What is this thing? - AoC Task 1
# Combine the fist and last digit of each line of the input to create a single two digit number
# Sum all of those together

def Part1(check):
    first_last = []
    with open(r"../inputs/day1.txt") as file:
        for line in file:
            first = next((ele for ele in line if ele in check), None) #should have used index not next()
            last = next((ele for ele in line[::-1] if ele in check), None)
            both = (first,last)
            first_last.append("".join(both))          
    numbers =[int(i) for i in first_last]
    total = sum(numbers)
    return total

def Part2(check):
    replacements = {"one":"1", "two":"2", "three":"3", "four":"4", "five":"5", "six":"6", "seven":"7", "eight":"8", "nine":"9"}
    first_last = []
    with open(r"../inputs/day1.txt") as file:
        for line in file:
            first = None
            last = None
            rev_line = line[::-1]
            rev_check = [i[::-1] for i in check]
            for f in check:
                if f in line and (first is None or line.index(f) < line.index(first)):
                    first = f
            for l in rev_check:
                 if l in rev_line and (last is None or rev_line.index(l) < rev_line.index(last)):
                    last = l
                    flip_last = last[::-1]
            b = (first,flip_last)
            replacer = replacements.get
            both = [replacer(n, n) for n in b]
            first_last.append("".join(both))
    numbers =[int(i) for i in first_last] # Orginally eval() - that was a bad idea.
    total = sum(numbers)
    return total

search_list1 = ["1", "2", "3", "4", "5", "6", "7", "8", "9",]
search_list2 = ["1", "2", "3", "4", "5", "6", "7", "8", "9", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"]

print(f"The answer for part 1 is: {Part1(search_list1)}")
print(f"The answer for part 2 is: {Part2(search_list2)}")
input("press the anykey to continue...")