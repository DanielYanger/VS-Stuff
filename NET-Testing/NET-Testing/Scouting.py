import requests
import json
import os
import sys

event_key = sys.argv[1]
api_key = sys.argv[2]
print(event_key)
full_matchlist =[]

#Blue Alliance API v3 Call
parameters = {"accept": "application/json", "X-TBA-Auth-Key": api_key}
print(event_key)
match_api = requests.get("https://www.thebluealliance.com/api/v3/event/"+event_key+"/matches/simple",params=parameters)
json_data = match_api.json()


#creating a new file
username = os.getlogin()
f = open(f'C:\\Users\\{username}\\Desktop\\schedule.txt',"w")
print("hello")

#making a sorted list
qual_matches=[]

for i in json_data:
    if i['comp_level']=='qm':
        qual_matches.append(i)

sorted_match_data = sorted(qual_matches,key=lambda x: x['match_number'])

#yeet decided to learn json instead
for i in sorted_match_data:
    if i['comp_level']=='qm':
        match_number = i['match_number']
        for team in i['alliances']['red']['team_keys']:
            f.write("Match "+str(match_number)+","+team[3:]+";")
        for team in i['alliances']['blue']['team_keys']:
            f.write("Match "+str(match_number)+","+team[3:]+";")


print("hello")