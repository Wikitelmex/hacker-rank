#!/bin/ruby

require 'json'
require 'stringio'
require 'pry'

#
# Complete the 'countingValleys' function below.
#
# The function is expected to return an INTEGER.
# The function accepts following parameters:
#  1. INTEGER steps
#  2. STRING path
#

def countingValleys(steps, path)
  valleys = 0
  current_level= 0
  patharr = path.split("")
  patharr.each do |step|
    if step == 'D'
      current_level -= 1
    elsif step == 'U'
      current_level += 1
    end
    if current_level == 0 && step == 'U'
      valleys += 1
    end 
  end
  valleys
end


result = countingValleys 8, 'UDDDUDUU'
puts result
