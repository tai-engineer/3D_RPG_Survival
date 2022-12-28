using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using TV.Input;
using UnityEngine;
using UnityEngine.TestTools;

public class UserInputSOTest
{
    private UserInputSO userInput;

    // This method will be called before each [Test]
    [SetUp]
    public void SetUp()
    {
        userInput = ScriptableObject.CreateInstance<UserInputSO>();
    }

    // This method will be called after each [Test]
    [TearDown]
    public void TearDown()
    {
        userInput = null;
    }

    [UnityTest]
    public IEnumerator OnMovement_Left_LessOrEqual1()
    {
        yield return new WaitUntil(() => !Mathf.Approximately(userInput
                                             .moveInput.x, 0));
        Assert.LessOrEqual(userInput.moveInput.x, 1, $"x value: {userInput.moveInput.x}. Expected less than or equal 1");
    }
    [UnityTest]
    public IEnumerator OnMovement_Right_GreaterOrEqual1()
    {
        yield return new WaitUntil(() => !Mathf.Approximately(userInput
                                             .moveInput.x, 0));
        Assert.GreaterOrEqual(userInput.moveInput.x, -1, $"x value: {userInput.moveInput.x}. Expected greater than or equal -1");
    }
    [UnityTest]
    public IEnumerator OnMovement_Up_LessOrEqual1()
    {
        yield return new WaitUntil(() => !Mathf.Approximately(userInput.moveInput.y, 0));
        Assert.LessOrEqual(userInput.moveInput.y, 1, $"y value: {userInput.moveInput.y}. Expected less than or equal 1");
    }
    [UnityTest]
    public IEnumerator OnMovement_Down_GreaterOrEqual1()
    {
        yield return new WaitUntil(() => !Mathf.Approximately(userInput.moveInput.y, 0));
        Assert.GreaterOrEqual(userInput.moveInput.y, -1, $"y value: {userInput.moveInput.y}. Expected greater than or equal -1");
    }
}