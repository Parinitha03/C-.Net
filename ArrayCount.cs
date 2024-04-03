int[] myArr = {1,1,2,2,2,3,3,3,3,5,5,6,7,8};

Dictionary<int, int> myHashMap = new Dictionary<int, int>();
for (var i = 0; i < myArr.Length; i++ ){
    int myKey = myArr[i]; 
    if (myHashMap.ContainsKey(myKey)){
        myHashMap[myKey] += 1;
    }else{
        myHashMap[myKey] = 1;
    }
}

foreach (KeyValuePair<int, int> kvp in myHashMap){
    Console.Write(kvp.Key+"="+kvp.Value+" ");
} 






