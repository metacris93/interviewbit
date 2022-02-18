static int majorityElement(List<int> A) {
  if (A.Count() == 1) return A[0];
  var dict = new Dictionary<int,int>();
  foreach (var i in A)
  {
    if (dict.ContainsKey(i))
      dict[i]++;
    else
      dict[i] = 1;
  }
  var res = dict.First(x => x.Value == dict.Values.Max()).Key;
  return res;
}
majorityElement(new List<int>() { 1,1,2 });