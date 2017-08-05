using System;
using Xunit;
using Moq;

namespace NetCoreConsoleApp.Test
{
    // Calculation �̃e�X�g�N���X
    public class CalculationTests
    {
        // AddDouble �̃e�X�g���\�b�h
        [Fact]
        public void AddDoubleTest()
        {
            // AddDouble ���e�X�g���邽�߂ɂ� ICalculation �� Add ����������Ă���K�v������
            // �Ȃ̂ŁAICalculation �̃��b�N���쐬����
            var mock = new Mock<ICalculation>();

            // Add ���\�b�h�̓�����`����
            // �����ł͈����Ƃ��� 2 �� 3 ��^�������� 5 ��Ԃ��悤�ɒ�`���Ă���
            mock.Setup(m => m.Add(2, 3)).Returns(5);

            // ���b�N�̏��������������̂ŁA�e�X�g�R�[�h������

            // ���b�N�������œn���ăe�X�g�Ώۂ̃N���X���C���X�^���X������
            var target = new Calculation(mock.Object);

            //�@���s�ƌ��ʂ̔���
            Assert.Equal(10, target.AddDouble(2, 3));
        }
    }
}
