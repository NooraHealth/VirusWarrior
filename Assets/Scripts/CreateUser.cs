using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using Firebase.Unity;
// using Firebase.Unity.Editor;
using System;
// using Firebase.Database;
// using Firebase.Auth;
using Firebase;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;
// using Firebase.Task;
using Firebase.Extensions;
// using TMPro;

public class CreateUser : MonoBehaviour
{
    /*
    private Firebase.Auth.FirebaseAuth auth;

    public GameObject SignInMenu;
    public GameObject StartGameMenu;

    // public bool signInAndFetchProfile = true;
    
    // public TMP_InputField displayNameTMP;
    public TMP_InputField phoneNumberTMP;
    public TMP_InputField receivedCodeTMP;

    // Set the phone authentication timeout to a minute.
    private uint phoneAuthTimeoutMs = 60 * 1000;
    // The verification id needed along with the sent code for phone authentication.
    private string phoneAuthVerificationId;


    // When the app starts, check to make sure that we have
    // the required dependencies to use Firebase, and if not,
    // add them if possible.
    private void Start()
    {
        auth = Firebase.Auth.FirebaseAuth.DefaultInstance;
        phoneAuthVerificationId = PlayerPrefs.GetString("AUTH_ID");

        Firebase.FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(task =>
        {
            var dependencyStatus = task.Result;
            if (dependencyStatus == Firebase.DependencyStatus.Available)
            {
                // Create and hold a reference to your FirebaseApp,
                // where app is a Firebase.FirebaseApp property of your application class.
                //   app = Firebase.FirebaseApp.DefaultInstance;

                // Set a flag here to indicate whether Firebase is ready to use by your app.
            }
            else
            {
                UnityEngine.Debug.LogError(System.String.Format(
                  "Could not resolve all Firebase dependencies: {0}", dependencyStatus));
                // Firebase Unity SDK is not safe to use here.
            }
        });
    }


    /*
        void AuthStateChanged(object sender, System.EventArgs eventArgs)
        {
            if (auth.CurrentUser != user)
            {
                bool signedIn = user != auth.CurrentUser && auth.CurrentUser != null;
                if (!signedIn && user != null)
                {
                    Debug.Log("Signed out " + user.UserId);
                }
                user = auth.CurrentUser;
                if (signedIn)
                {
                    Debug.Log("Signed in " + user.UserId);
                    displayName = user.DisplayName ?? "";
                    emailAddress = user.Email ?? "";
                    photoUrl = user.PhotoUrl ?? "";
                }
            }
        }
            // Create a user with the email and password.
            public Task CreateUserWithEmailAsync()
            {
                // This passes the current displayName through to HandleCreateUserAsync
                // so that it can be passed to UpdateUserProfile().  displayName will be
                // reset by AuthStateChanged() when the new user is created and signed in.
                string newDisplayName = displayName;
                return auth.CreateUserWithEmailAndPasswordAsync(email, password)
                  .ContinueWithOnMainThread((task) =>
                  {
                      EnableUI();
                      if (LogTaskCompletion(task, "User Creation"))
                      {
                          var user = task.Result;
                          DisplayDetailedUserInfo(user, 1);
                          return UpdateUserProfileAsync(newDisplayName: newDisplayName);
                      }
                      return task;
                  }).Unwrap();
            }

            // Update the user's display name with the currently selected display name.
            public Task UpdateUserProfileAsync(string newDisplayName = null)
            {
                if (auth.CurrentUser == null)
                {
                    Debug.Log("Not signed in, unable to update user profile");
                    return Task.FromResult(0);
                }
                displayName = newDisplayName ?? displayName;
                Debug.Log("Updating user profile");
                DisableUI();
                return auth.CurrentUser.UpdateUserProfileAsync(new Firebase.Auth.UserProfile
                {
                    DisplayName = displayName,
                }).ContinueWithOnMainThread(task =>
                {
                    if (LogTaskCompletion(task, "User profile"))
                    {
                        DisplayDetailedUserInfo(auth.CurrentUser, 1);
                    }
                });
            }
        */
    /*
        public void VerifyPhoneNumber()
        {
            // var displayName = displayNameTMP.text;

            var phoneNumber = "+91" + phoneNumberTMP.text;
            Debug.Log("Entered Number " + phoneNumber);
            var phoneAuthProvider = Firebase.Auth.PhoneAuthProvider.GetInstance(auth);
            phoneAuthProvider.VerifyPhoneNumber(phoneNumber, phoneAuthTimeoutMs, null,
              verificationCompleted: (cred) =>
              {
                  Debug.Log("Phone Auth, auto-verification completed");
                  SignInMenu.SetActive(false);
                  StartGameMenu.SetActive(true);

              },
              verificationFailed: (error) =>
              {
                  Debug.Log("Phone Auth, verification failed: " + error);
              },
              codeSent: (id, token) =>
              {
                  phoneAuthVerificationId = id;
                  PlayerPrefs.SetString("AUTH_ID", id);
                  Debug.Log("Phone Auth, code sent");
                  PlayerPrefs.Save();

              },
              codeAutoRetrievalTimeOut: (id) =>
              {
                  Debug.Log("Phone Auth, auto-verification timed out");
              });
        }

        // Sign in using phone number authentication using code input by the user.
        public void VerifyReceivedPhoneCode()
        {
            var receivedCode = receivedCodeTMP.text;
            Debug.Log("Entered Code " + receivedCode);
            var phoneAuthProvider = Firebase.Auth.PhoneAuthProvider.GetInstance(auth);
            // receivedCode should have been input by the user.
            var cred = phoneAuthProvider.GetCredential(phoneAuthVerificationId, receivedCode);
            auth.SignInWithCredentialAsync(cred).ContinueWith(task =>
            {
                if (task.IsFaulted)
                {
                    Debug.LogError("SignInWithCredentialAsync encountered an error: " +
                                   task.Exception);
                    return;
                }

                Firebase.Auth.FirebaseUser newUser = task.Result;
                Debug.Log("User signed in successfully");
                // This should display the phone number.
                Debug.Log("Phone number: " + newUser.PhoneNumber);
                PlayerPrefs.SetString("PHNO", newUser.PhoneNumber);
                // The phone number providerID is 'phone'.
                Debug.Log("Phone provider ID: " + newUser.ProviderId);
                PlayerPrefs.SetString("PROVIDER_ID", newUser.ProviderId);
                SignInMenu.SetActive(false);
                StartGameMenu.SetActive(true);
                PlayerPrefs.Save();
            });
        }

        // public void getUserInfo()
        // {
        //     Firebase.Auth.FirebaseUser user = auth.CurrentUser;
        //     if (user != null)
        //     {
        //         string name = user.DisplayName;
        //         // The user's Id, unique to the Firebase project.
        //         // Do NOT use this value to authenticate with your backend server, if you
        //         // have one; use User.TokenAsync() instead.
        //         string uid = user.UserId;
        //     }
        // }

        // Sign out the current user.
        public void SignOut()
        {
            Debug.Log("Signing out.");
            auth.SignOut();
        }

        */
}
