Imports DPFP
Imports DPFP.Capture
Imports DPFP.Processing
Imports System.Drawing

Public Class FingerprintHandler
    Implements DPFP.Capture.EventHandler

    Private capturer As DPFP.Capture.Capture
    Private fingerprintTemplate As DPFP.Template
    Public Event FingerprintCaptured(ByVal fingerprintImage As Bitmap, ByVal templateBytes As Byte())
    Public Event FingerprintReaderStatus(ByVal message As String)

    Public Sub New()
        Init()
    End Sub

    ' Initialize the fingerprint capture device
    Private Sub Init()
        Try
            capturer = New DPFP.Capture.Capture()
            If capturer IsNot Nothing Then
                capturer.EventHandler = Me
                RaiseEvent FingerprintReaderStatus("Fingerprint reader initialized successfully.")
            End If
        Catch ex As Exception
            RaiseEvent FingerprintReaderStatus("Failed to initialize fingerprint reader: " & ex.Message)
        End Try
    End Sub

    ' Start capturing fingerprint
    Public Sub StartCapture()
        If capturer IsNot Nothing Then
            Try
                capturer.StartCapture()
                RaiseEvent FingerprintReaderStatus("Capturing fingerprint...")
            Catch ex As Exception
                RaiseEvent FingerprintReaderStatus("Error starting capture: " & ex.Message)
            End Try
        End If
    End Sub

    ' Stop capturing fingerprint
    Public Sub StopCapture()
        If capturer IsNot Nothing Then
            Try
                capturer.StopCapture()
                RaiseEvent FingerprintReaderStatus("Capture stopped.")
            Catch ex As Exception
                RaiseEvent FingerprintReaderStatus("Error stopping capture: " & ex.Message)
            End Try
        End If
    End Sub

    ' Handle OnComplete event from the fingerprint reader
    Public Sub OnComplete(Capture As Object, ReaderSerialNumber As String, Sample As DPFP.Sample) Implements DPFP.Capture.EventHandler.OnComplete
        Dim features As DPFP.FeatureSet = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification)
        If features IsNot Nothing Then
            fingerprintTemplate = New DPFP.Template()
            fingerprintTemplate.DeSerialize(features.Bytes)

            ' Convert sample to Bitmap and raise event
            Dim fingerprintImage As Bitmap = ConvertSampleToBitmap(Sample)
            RaiseEvent FingerprintCaptured(fingerprintImage, fingerprintTemplate.Bytes)
            RaiseEvent FingerprintReaderStatus("Fingerprint captured successfully.")
        Else
            RaiseEvent FingerprintReaderStatus("Failed to extract features from fingerprint.")
        End If
    End Sub

    ' Extract features from fingerprint sample
    Private Function ExtractFeatures(ByVal sample As DPFP.Sample, ByVal purpose As DPFP.Processing.DataPurpose) As DPFP.FeatureSet
        Dim extractor As DPFP.Processing.FeatureExtraction = New DPFP.Processing.FeatureExtraction()
        Dim feedback As DPFP.Capture.CaptureFeedback = DPFP.Capture.CaptureFeedback.None
        Dim features As DPFP.FeatureSet = New DPFP.FeatureSet()
        extractor.CreateFeatureSet(sample, purpose, feedback, features)

        If feedback = DPFP.Capture.CaptureFeedback.Good Then
            Return features
        Else
            Return Nothing
        End If
    End Function

    ' Convert sample to Bitmap
    Private Function ConvertSampleToBitmap(ByVal sample As DPFP.Sample) As Bitmap
        Dim converter As New DPFP.Capture.SampleConversion()
        Dim bitmap As Bitmap = Nothing
        converter.ConvertToPicture(sample, bitmap)
        Return bitmap
    End Function

    ' Handle OnFingerGone event (finger removed)
    Public Sub OnFingerGone(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerGone
        RaiseEvent FingerprintReaderStatus("Finger removed from the reader.")
    End Sub

    ' Handle OnFingerTouch event (finger placed)
    Public Sub OnFingerTouch(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerTouch
        RaiseEvent FingerprintReaderStatus("Finger detected on the reader.")
    End Sub

    ' Handle OnReaderConnect event (reader connected)
    Public Sub OnReaderConnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderConnect
        RaiseEvent FingerprintReaderStatus("Fingerprint reader connected.")
    End Sub

    ' Handle OnReaderDisconnect event (reader disconnected)
    Public Sub OnReaderDisconnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderDisconnect
        RaiseEvent FingerprintReaderStatus("Fingerprint reader disconnected.")
    End Sub

    ' Handle OnSampleQuality event (sample quality feedback)
    Public Sub OnSampleQuality(Capture As Object, ReaderSerialNumber As String, CaptureFeedback As CaptureFeedback) Implements EventHandler.OnSampleQuality
        Select Case CaptureFeedback
            Case CaptureFeedback.Good
                RaiseEvent FingerprintReaderStatus("Sample quality is good.")
            Case CaptureFeedback.NotEnoughFeatures
                RaiseEvent FingerprintReaderStatus("Sample quality is bad, please try again.")
            Case Else
                RaiseEvent FingerprintReaderStatus("Sample quality feedback not available.")
        End Select
    End Sub
End Class
