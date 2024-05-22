using Microsoft.JSInterop;

namespace TangyWeb_Server.Helper
{
    public static class IJSRuntimeExtention
    {
        public static async ValueTask ToastrSuccess(this IJSRuntime jSRuntime,String message)
        {
            await jSRuntime.InvokeVoidAsync("ShowToastr", "success", message);
        }
        public static async ValueTask ToastrError(this IJSRuntime jSRuntime, String message)
        {
            await jSRuntime.InvokeVoidAsync("ShowToastr", "error", message);

        }
    }
}
