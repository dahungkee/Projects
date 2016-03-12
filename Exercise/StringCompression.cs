string CompressString(string input) {
  char currentLetter ;
  int count = 0;
  StringBuilder sb = new StringBuilder();
  
  for (int i = 0; i < input.Length; i++) {
    if (count == 0) {
      currentLetter = input[i];
      count = 1;
    } else if (currentLetter == input[i]) {
      count++;
    } else {
      sb.Append(currentLetter).Append(count);
      currentLetter = input[i];
      count = 1;
    }
  }

  if (count > 0) {
    sb.Append(currentLetter).Append(count);
  }
}
