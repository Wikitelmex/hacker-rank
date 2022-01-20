#!/bin/ruby

require 'json'
require 'stringio'

#
# Complete the 'alternatingCharacters' function below.
#
# The function is expected to return an INTEGER.
# The function accepts STRING s as parameter.
#

def alternatingCharacters(s)
    # Write your code here
    pattern_a = "aa"
    pattern_b = "bb"
    s.downcase.scan(/(?=#{pattern_a})/).count + s.downcase.scan(/(?=#{pattern_b})/).count
end

fptr = File.open(ENV['OUTPUT_PATH'], 'w')

q = gets.strip.to_i

q.times do |q_itr|
    s = gets.chomp

    result = alternatingCharacters s

    fptr.write result
    fptr.write "\n"
end

fptr.close()
