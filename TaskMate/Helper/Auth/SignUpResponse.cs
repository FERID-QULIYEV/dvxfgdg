﻿namespace TaskMate.Helper.Auth;

public class SignUpResponse
{
    public List<string> Errors { get; set; } = new List<string>();
    public string StatusMessage { get; set; }
    public string UserEmail { get; set; }
}