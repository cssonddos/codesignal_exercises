string[][] groupingDishes(string[][] dishes) {
    
    Dictionary<string, List<string>> ing = new Dictionary<string, List<string>>();
    
    foreach(string[] d in dishes){
        if (d == null) continue;
        string dish = d[0];
        
        for(int i=1; i < d.Count(); i++){
            if(!ing.ContainsKey(d[i])){
                ing.Add(d[i], new List<string>());
            }
            ing[d[i]].Add(dish);
            
        }
    }
    
    List<String> keys = ing.Keys.ToList();
    keys.Sort((x,y) => String.CompareOrdinal(x,y));
    
    List<string[]> res = new List<string[]>();
    foreach(string d in keys){
        if(ing[d].Count() > 1){
            ing[d].Sort((x,y) => String.CompareOrdinal(x,y));
            ing[d].Insert(0, d);
            
            res.Add(ing[d].ToArray());
        }
    }
    
    return res.ToArray();
}
