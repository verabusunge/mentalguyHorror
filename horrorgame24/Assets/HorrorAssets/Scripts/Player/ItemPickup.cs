using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public Camera playerCamera;
    [SerializeField] private float pickupRange = 3f;
    [SerializeField] private float holdDistance = 2f;
    [SerializeField] private float rotationSpeed = 100f;

    private GameObject heldItem;
    private bool isHoldingItem;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (isHoldingItem)
            {
                DropItem();
            }
            else
            {
                TryPickupItem();
            }
        }

        if (isHoldingItem)
        {
            HoldItem();
            RotateHeldItem();
        }
    }

    private void TryPickupItem()
    {
        Ray ray = playerCamera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit, pickupRange))
        {
            if (hit.collider.CompareTag("Pickup"))
            {
                heldItem = hit.collider.gameObject;
                PrepareItemForHolding();
            }
        }
    }

    private void PrepareItemForHolding()
    {
        Rigidbody rb = heldItem.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.isKinematic = true;
        }
        isHoldingItem = true;
    }

    private void HoldItem()
    {
        Vector3 targetPosition = playerCamera.transform.position + playerCamera.transform.forward * holdDistance;
        heldItem.transform.position = targetPosition;
    }

    private void RotateHeldItem()
    {
        float rotationX = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
        float rotationY = Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;

        heldItem.transform.Rotate(playerCamera.transform.up, -rotationX, Space.World);
        heldItem.transform.Rotate(playerCamera.transform.right, rotationY, Space.World);
    }

    private void DropItem()
    {
        if (heldItem != null)
        {
            Rigidbody rb = heldItem.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.isKinematic = false;
                rb.AddForce(playerCamera.transform.forward * 2f, ForceMode.Impulse);
            }
        }
        heldItem = null;
        isHoldingItem = false;
    }
}