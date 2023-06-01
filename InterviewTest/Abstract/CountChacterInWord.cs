using InterviewTest.Models;
using InterviewTest.Abstract;

namespace InterviewTest.Abstract
{
    public class CountCharacterInWord: ICountCharacterWord
    {
       
      async  Task<NumberofCharacterResponse> ICountCharacterWord.GetChacterCounts(string input)
        {
            try
            {
                string Input = input.Replace(" ", string.Empty);
                NumberofCharacterResponse response = new NumberofCharacterResponse()
                {
                    CharandCount = new List<CharacterCount>()
                };

                while (Input.Length > 0)
                {

                    int count = 0;
                    for (int j = 0; j < Input.Length; j++)
                    {
                        if (Input[0] == Input[j])
                        {
                            count++;
                        }
                    }


                    response.CharandCount.Add(new CharacterCount()
                    {
                        Character = Input[0],
                        Count = count
                    });
                    Input = Input.Replace(Input[0].ToString(), string.Empty);

                }

                return response;
            }
            catch (Exception ex)
            {
                string msg=ex.Message.ToString();
                return null;
            }
            
            
        }

       
    }
}
