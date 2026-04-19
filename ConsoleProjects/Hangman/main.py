# Build a curated list of Hangman words (500 items) and save to a text file

categories = []

# Basic objects/tech
categories += [
"car","computer","keyboard","mouse","monitor","phone","tablet","laptop","printer","camera",
"speaker","headphone","router","server","cable","battery","charger","screen","microphone","drone",
"robot","console","joystick","controller","software","hardware","program","code","system","network",
"database","algorithm","application","browser","window","folder","file","desktop","laptopcase","usb",
"drive","disk","chip","processor","memory","graphics","display","sensor","switch","button","remote"
]

# Nature
categories += [
"tree","forest","river","mountain","ocean","lake","sea","sky","cloud","rain",
"snow","storm","wind","sun","moon","star","planet","earth","valley","desert",
"island","beach","rock","stone","grass","flower","leaf","branch","root","soil",
"volcano","glacier","waterfall","canyon","hill","field","jungle","bush","reef","cliff"
]

# Animals
categories += [
"dog","cat","lion","tiger","elephant","giraffe","zebra","monkey","bear","wolf",
"fox","rabbit","horse","cow","sheep","goat","pig","chicken","duck","eagle",
"falcon","owl","snake","lizard","frog","whale","dolphin","shark","octopus","crab",
"ant","bee","butterfly","spider","turtle","kangaroo","panda","leopard","cheetah","parrot"
]

# Food
categories += [
"apple","banana","orange","grape","pear","peach","plum","cherry","mango","melon",
"bread","cheese","butter","milk","yogurt","egg","meat","fish","rice","pasta",
"pizza","burger","sandwich","salad","soup","cake","cookie","chocolate","candy","honey",
"tomato","potato","carrot","onion","garlic","pepper","salt","sugar","coffee","tea"
]

# Actions/verbs
categories += [
"run","walk","jump","swim","fly","drive","write","read","code","build",
"create","destroy","break","fix","open","close","start","stop","move","push",
"pull","lift","drop","throw","catch","shoot","draw","paint","sing","dance",
"think","learn","teach","play","work","sleep","wake","eat","drink","grow"
]

# Adjectives
categories += [
"fast","slow","big","small","hot","cold","warm","cool","bright","dark",
"happy","sad","angry","calm","strong","weak","hard","soft","light","heavy",
"rich","poor","young","old","new","clean","dirty","loud","quiet","sharp",
"flat","round","deep","shallow","high","low","wide","narrow","long","short"
]

# Additional mixed words to reach 500
extra = [
"bridge","building","city","village","country","road","street","train","bus","plane",
"airport","station","hospital","school","university","library","museum","market","shop","store",
"money","bank","credit","account","wallet","coin","gold","silver","diamond","jewel",
"phonecase","backpack","suitcase","jacket","shirt","pants","shoes","gloves","hat","belt",
"clock","watch","calendar","notebook","pencil","pen","eraser","paper","stapler","scissors",
"lamp","lightbulb","fan","heater","fridge","oven","stove","sink","mirror","door",
"windowpane","roof","floor","wall","ceiling","stairs","elevator","garage","garden","yard",
"fire","smoke","ice","sand","dust","mud","windmill","battery","engine","motor",
"wheel","brake","pedal","seat","handle","lock","key","chain","rope","hook"
]

categories += extra


# Trim if over
categories = categories[:500]

file_path = r"C:\Users\Ninikashvili\Documents\C# Projects\ConsoleProjects\Hangman\hangman_words.txt"
with open(file_path, "w") as f:
    f.write("\n".join(categories))

len(categories), file_path