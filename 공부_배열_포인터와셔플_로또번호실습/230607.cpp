#include <iostream>
#include <stdint.h>
#include<windows.h>

void Description001();
void Description002();
void Description003();
void Description004();
void Description005();
void Swap(char firstchar, char secondchar);
void Swap2(char* firstchar, char* secondchar);
void Description006();
void DescShuffle();
void ShuffleOnce(int* firstnumber, int* secondnumber);
void lotto();

int main()
{
    /*Description001();
    Description002();
    Description003();
    Description004();
    Description005();
    Description006();
    DescShuffle();*/
    lotto();
}

void Description001() // 배열과 NULL
{
    char string_[15] = "Good morning!\n";
    char stringCopy[16] = { 0, };

    char string_2[] = "Good morning! \n";
    int numbers[10] = { 0, };

    printf("문자열 배열의 크기 %d \n", sizeof(string_) * sizeof(char));
    printf("문자열 배열 2번째 것의 크기 %d \n", sizeof(string_2));
    printf("정수형 배열의 크기 %d \n", sizeof(numbers));      // 정수인 int의 크기가 4라서 4*10 이 되어 40이 나왔다.
    printf("정수형 배열의 길이 %d \n", sizeof(numbers) / sizeof(int));

    // { 선언 후 배열 수정이 가능한지 테스트
    string_[0] = 'G';
    string_[1] = 'g';
    string_[2] = 'g';
    printf("문자열 배열이 정말로 수정되는지? -> %s \n", string_);
    // } 답은 가능하다.


    bool isNullSameZero = false;
    if (0 == '\0')
    {
        isNullSameZero = true;
    }
    else
    {
        isNullSameZero = false;
    }

    printf(" Null은 0과 같은 값인가? : [%d] \n ", isNullSameZero);

    // { NULL 의 예시, 쓰이는 곳
    char string3[4];
    string3[0] = 'H';
    string3[1] = 'i';
    string3[2] = '!';
    string3[3] = '\0';      // 끝에 Null을 넣어 끝을 지정해주면 string3번이 정상적으로 나온다.

    char string4[4] = "Hi!";

    printf("string3번 찍어보겠음 -> %s \n", string3);
    printf("string4번 찍어보겠음 -> %s \n", string4);
    // } NULL 의 예시, 쓰이는 곳
}

void Description002() // 배열과 문자열
{
    char str[300] = { 0, };

    printf("문자열을 입력하시오(200자 이내로): \n");
    std::cin >> str;

    printf("제대로 입력을 받았는지? -> %s \n", str);
}

void Description003() // 위에 1, 2를 이용한 실습 ( Easy )
{
    char string_A[200] = { 0, };

    printf(" 문자열을 입력하세요 ");
    std::cin >> string_A;
    int Change = 0;
    int ex = 0;

    while (Change <= 200)
    {
        if (('A' <= string_A[Change] && string_A[Change] <= 'Z') || ('a' <= string_A[Change] && string_A[Change] <= 'z'))
        {
            if ((Change + ex) % 2)   // 대문자
            {
                if ('A' <= string_A[Change] && string_A[Change] <= 'Z')
                {
                    string_A[Change] += 32;
                }
                else
                {
                }
            }
            else                     // 소문자
            {
                if ('a' <= string_A[Change] && string_A[Change] <= 'z')
                {
                    string_A[Change] -= 32;
                }
                else
                {
                }
            }
        }
        else
        {
            ex += 1;
        }
        Change += 1;

    }

    printf("%s", string_A);
}// 대 - 소 - 대 - 소 . . . 순으로 출력 ( 특수문자는 건너뜀 )

void Description004() // 위에 1, 2를 이용한 실습 ( Hard )
{
    char string_A[200] = { 0, };

    printf(" 입력 : ");
    std::cin >> string_A;

    int Change = 0;   // 문자열 n번째 ( 0에서 시작 )
    int ex = 0;   // +1이 되면 건너뛰게 하려고 만든 변수

    while (Change <= 200)
    {
            if (('A' <= string_A[Change] && string_A[Change] <= 'Z') || ('a' <= string_A[Change] && string_A[Change] <= 'z'))
            {
                if ((Change + ex) % 2)   // 대문자
                {
                    if ('A' <= string_A[Change] && string_A[Change] <= 'Z')   // 소문자라면
                    {
                        string_A[Change] += 32;   // 대문자로 변환
                    }
                    else
                    {
                    }
                }
                else   // 소문자
                {
                    if ('a' <= string_A[Change] && string_A[Change] <= 'z')   // 대문자라면
                    {
                        string_A[Change] -= 32;   // 소문자로 변환
                    }
                    else
                    {
                    }
                }
            }
            else   // 특수문자 건너뛰기
            {
                ex += 1;
            }
            Change += 1;

    }

    printf("%s\n\n", string_A);

    int count = 200;   // 문자열 크기

    while (count >= 0)   // 문자열 크기가 0보다 크면 출력
    {
        printf("%c", string_A[count]);
        count -= 1;   // 출력할 때마다 -1 씩 줄어든다.
    }
}

//
void Description005()
{
    char str[10] = "Hello";   // index는 0 부터 시작
    char temp = '\0';

  /*  temp = str[0];
    str[0] = str[4];
    str[4] = temp;
    printf("str의 0번째 값 : %c, str의 4번째 값 : %c \n", str[0], str[4]);*/

    Swap2(&str[0], &str[4]);
    printf("%s \n", str);

}
void Swap(char firstchar, char secondchar)
{
    printf(" [ 스왑하기 전 ] firstchar 값 : %c , secondchar 값 : %c \n", firstchar, secondchar);

    char temp = '\0';

    temp = firstchar;
    firstchar = secondchar;
    secondchar = temp;

    printf(" [ 스왑 이후 ] firstchar 값 : %c , secondchar 값 : %c \n", firstchar, secondchar);

}
void Swap2(char* firstchar, char* secondchar)
{
    printf(" [ 스왑하기 전 ] firstchar 값 : %c , secondchar 값 : %c \n", *firstchar, *secondchar);

    char temp = '\0';

    temp = (*firstchar);
    (*firstchar) = (*secondchar);
    (*secondchar) = temp;

    printf(" [ 스왑 이후 ] firstchar 값 : %c , secondchar 값 : %c \n", *firstchar, *secondchar);

}
//

void Description006()
{
    // 포인터 직접 쳐보기
    int number = 100;
    int* ptrNumber = &number;

    printf("number 변수의 주소는 : %p, 할당된 값은 : %d \n",&number, number);
    printf("ptrNumber 변수의 주소는 : %p, 할당된 값은 %p , 역참조인 값 : %d \n", &ptrNumber, ptrNumber,*ptrNumber);
}
void DescShuffle()
{
    // { 배열의 선언과 초기화
    int numbers[10] = { 0, }; 

    for (int i = 0; i < 10; i++)
    {
        numbers[i] = i + 1;
    }
    // } 배열의 선언과 초기화


    // { 배열의 출력
    printf("shuffle 하기 전 \n\n ");
    for (int i = 0; i < 10; i++)
    {
        printf("%d ", numbers[i]);
    }
     printf("\n");
    // } 배열의 출력

     // { 셔플 로직
     const int shuffleCount = 200;
     int randomIdx1, randomIdx2 = 0;
     srand(time(NULL));
     for (int i = 0; i < shuffleCount; i++)
     {
         randomIdx1 = rand() % 10;
         randomIdx2 = rand() % 10;
         ShuffleOnce(&numbers[randomIdx1], &numbers[randomIdx2]);
     }
     printf("\n");
     // } 셔플로직

     // { 배열의 출력
     printf("shuffle 한 후 \n\n ");
     for (int i = 0; i < 10; i++)
     {
         printf("%d ", numbers[i]);
     }
     printf("\n");
     // } 배열의 출력

}      // DescShuffle()
void ShuffleOnce(int* firstnumber, int* secondnumber)
{
    int temp = 0;
    temp = *firstnumber;
    *firstnumber = *secondnumber;
    *secondnumber = temp;
}      // shuffleOnce()


void lotto() // 위에 셔플을 이용해 로또번호 6개를 뽑기
{
    int numbers[45] = { 0, };
    for (int i = 0; i < 45; i++)
    {
        numbers[i] = i + 1;
    }

    const int shufflelotto = 200;
    int random1, random2 = 0;
    srand(time(NULL));
    for (int i = 0; i < shufflelotto; i++)
    {
        random1 = rand() % 45;
        random2 = rand() % 45;
        ShuffleOnce(&numbers[random1], &numbers[random2]);
    }

    for (int i = 0; i < 6; i++)
    {
        printf("로또 번호 : %d\n", numbers[i]);
        Sleep(800);
    }
}   